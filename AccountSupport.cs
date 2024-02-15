using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leaf.xNet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static RegAccGame.Shared;

namespace RegAccGame
{
    public class AccountSupport
    {
        public int index { get; set; }
        public string messenge { get; set; }
        private string access_token { get; set; }
        private string refresh_token { get; set; }
        private string captcha_solved { get; set; }
        private string captcha_value { get; set; }
        public string proxy { get; set; }
        public string user_agent { get; set; }
        public string captcha_key { get; set; }
        public string bank_id { get; set; }
        public string bank_name { get; set; }
        private DataGridView dataGridView;

        public AccountSupport(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
        }
        private void GetCaptcha()
        {
            using (HttpRequest request = new HttpRequest())
            {
                if (proxy != null)
                {
                    string[] proxy_split = proxy.Split(':');
                    HttpProxyClient proxy_client = new HttpProxyClient(proxy_split[0], Int32.Parse(proxy_split[1]));
                    request.Proxy = proxy_client;
                }
                messenge = "Getting captcha image...";
                dataGridView.Invoke(new Action(() =>
                {
                    dataGridView.Rows[index].Cells["col_status"].Value = messenge;
                    dataGridView.Refresh(); // Cập nhật giao diện người dùng
                }));
                request.AddHeader("User-Agent", user_agent);
                request.AddHeader("Origin", "https://789win19.com");
                request.AddHeader("Referer", "https://789win19.com/Register");
                 8HttpResponse getcaptchaResponse = request.Post("https://789win19.com/api/0.0/Home/GetCaptchaForRegister");
                if (getcaptchaResponse.StatusCode == HttpStatusCode.OK)
                {
                    messenge = "Getting image done";
                    dataGridView.Invoke(new Action(() =>
                    {
                        dataGridView.Rows[index].Cells["col_status"].Value = messenge;
                        dataGridView.Refresh(); // Cập nhật giao diện người dùng
                    }));
                    Shared.CaptchaResponse captcha_res = JsonConvert.DeserializeObject<Shared.CaptchaResponse>(getcaptchaResponse.ToString());
                    captcha_value = captcha_res.value;
                    Shared.CatpchaBody captcha_body = new Shared.CatpchaBody
                    {
                        clientKey = $"{captcha_key}",
                        task = new Task_
                        {
                            type = "ImageToTextTask",
                            body = captcha_res.image,
                            phrase = false,
                            @case = true,
                            numeric = 0,
                            math = false,
                            minLength = 0,
                            maxLength = 0,
                            comment = "Enter the text you see on the image, thank you <3"
                        },
                        languagePool = "en"
                    };
                    string body = JsonConvert.SerializeObject(captcha_body);
                    HttpResponse createTaskResponse = request.Post("https://api.2captcha.com/createTask", body, "application/json");
                    Shared.CreateTaskResponse createTask_res = JsonConvert.DeserializeObject<Shared.CreateTaskResponse>(createTaskResponse.ToString());
                    if (createTask_res.errorId == 0)
                    {
                        string task_body = "{\"clientKey\": \"" + captcha_key + "\",\"taskId\": " + createTask_res.taskId + "}";
                        while (true)
                        {
                            HttpResponse getTaskResultResponse = request.Post("https://api.2captcha.com/getTaskResult", task_body, "application/json");
                            Shared.CaptchaResult captchaResult = JsonConvert.DeserializeObject<Shared.CaptchaResult>(getTaskResultResponse.ToString());
                            if (captchaResult.errorId == 0)
                            {
                                if (captchaResult.status == "processing")
                                {
                                    Task.Delay(TimeSpan.FromSeconds(3)).Wait();
                                    messenge = "Solving captcha...";
                                    dataGridView.Invoke(new Action(() =>
                                    {
                                        dataGridView.Rows[index].Cells["col_status"].Value = messenge;
                                        dataGridView.Refresh(); // Cập nhật giao diện người dùng
                                    }));
                                    Task.Delay(500).Wait();
                                }
                                else
                                {
                                    if (captchaResult.status == "ready")
                                    {
                                        captcha_solved = captchaResult.solution.text;
                                        messenge = $"Captcha solved! => {captcha_solved}";
                                        dataGridView.Invoke(new Action(() =>
                                        {
                                            dataGridView.Rows[index].Cells["col_status"].Value = messenge;
                                            dataGridView.Refresh(); // Cập nhật giao diện người dùng
                                        }));
                                        break;
                                    }
                                    else
                                    {
                                        Shared.CaptchaError error = JsonConvert.DeserializeObject<Shared.CaptchaError>(getTaskResultResponse.ToString());
                                        messenge = error.errorCode;
                                        dataGridView.Invoke(new Action(() =>
                                        {
                                            dataGridView.Rows[index].Cells["col_status"].Value = messenge;
                                            dataGridView.Refresh(); // Cập nhật giao diện người dùng
                                        }));
                                    }
                                }
                            }
                            else
                            {
                                Shared.CaptchaError error = JsonConvert.DeserializeObject<Shared.CaptchaError>(createTaskResponse.ToString());
                                messenge = error.errorCode;
                                dataGridView.Invoke(new Action(() =>
                                {
                                    dataGridView.Rows[index].Cells["col_status"].Value = messenge;
                                    dataGridView.Refresh(); // Cập nhật giao diện người dùng
                                }));
                                break;
                            }
                        }
                    }
                    else
                    {
                        Shared.CaptchaError error = JsonConvert.DeserializeObject<Shared.CaptchaError>(createTaskResponse.ToString());
                        messenge = error.errorCode;
                        dataGridView.Invoke(new Action(() =>
                        {
                            dataGridView.Rows[index].Cells["col_status"].Value = messenge;
                            dataGridView.Refresh(); // Cập nhật giao diện người dùng
                        }));
                    }
                }
                else
                {
                    messenge = "Connection Error!";
                    dataGridView.Invoke(new Action(() =>
                    {
                        dataGridView.Rows[index].Cells["col_status"].Value = messenge;
                        dataGridView.Refresh(); // Cập nhật giao diện người dùng
                    }));
                }
            }
        }
        public List<string> GetListBank()
        {
            using (HttpRequest request = new HttpRequest())
            {
                if (proxy != null)
                {
                    string[] proxy_split = proxy.Split(':');
                    HttpProxyClient proxy_client = new HttpProxyClient(proxy_split[0], Int32.Parse(proxy_split[1]));
                    request.Proxy = proxy_client;
                }
                List<string> listBank = new List<string>();
                HttpResponse response = request.Get("https://789win19.com/api/1.0/site/banks");
                BankResponse bankResponse = JsonConvert.DeserializeObject<BankResponse>(response.ToString());
                foreach (var bank in bankResponse.Result.Banks)
                {
                    string bank_info = $"{bank.Id}|{bank.Name}";
                    listBank.Add(bank_info);
                }
                return listBank;
            }
        }
        public void Register(UserInfo user)
        {
            using (HttpRequest request = new HttpRequest())
            {
                GetCaptcha();
                Task.Delay(500).Wait();
                if (proxy != null)
                {
                    string[] proxy_split = proxy.Split(':');
                    HttpProxyClient proxy_client = new HttpProxyClient(proxy_split[0], Int32.Parse(proxy_split[1]));
                    request.Proxy = proxy_client;
                }
                request.UserAgent = user_agent;
                request.AddHeader("Origin", "https://789win19.com");
                request.AddHeader("Referer", "https://789win19.com/Register");
                RegisterInfo register_info = new RegisterInfo
                {
                    account = user.username,
                    password = user.password,
                    confirm_Password = user.password,
                    moneyPassword = null,
                    name = user.fullname,
                    countryCode = "84",
                    mobile = null,
                    email = null,
                    sex = null,
                    birthday = null,
                    idNumber = null,
                    qqAccount = null,
                    groupBank = null,
                    bankName = null,
                    bankProvince = null,
                    bankCity = null,
                    bankAccount = null,
                    checkCodeEncrypt = captcha_value,
                    checkCode = captcha_solved,
                    isRequiredMoneyPassword = false,
                    dealerAccount = null,
                    parentAccount = null
                };
                string register_body = JsonConvert.SerializeObject(register_info);
                HttpResponse register_response = request.Post("https://789win19.com/api/1.0/member/register", register_body, "application/json");
                RegisterResponse reg_res = JsonConvert.DeserializeObject<RegisterResponse>(register_response.ToString());
                if (reg_res.Code == 200)
                {
                    if (reg_res.Result.Token.AccessToken != null)
                    {
                        messenge = "Đăng ký thành công!";
                        dataGridView.Invoke(new Action(() =>
                        {
                            dataGridView.Rows[index].Cells["col_status"].Value = messenge;
                            dataGridView.Refresh(); // Cập nhật giao diện người dùng
                        }));
                        Task.Delay(500).Wait();
                        messenge = "Đang thêm MK rút tiền...";
                        dataGridView.Invoke(new Action(() =>
                        {
                            dataGridView.Rows[index].Cells["col_status"].Value = messenge;
                            dataGridView.Refresh(); // Cập nhật giao diện người dùng
                        }));
                        Task.Delay(500).Wait();
                        access_token = reg_res.Result.Token.AccessToken;

                        request.AddHeader("Referer", "https://789win19.com/Account/ChangeMoneyPassword");
                        request.AddHeader("Authorization", $"Bearer {access_token}");
                        string mnpass_body = "{\"newPassword\":\"" + user.wr_password + "\",\"confirmPassword\":\"" + user.wr_password + "\"}";
                        HttpResponse mnpass_response = request.Post("https://789win19.com/api/1.0/member/updateWithdrawPassword", mnpass_body, "application/json");
                        RegisterResponse mnpass_res = JsonConvert.DeserializeObject<RegisterResponse>(mnpass_response.ToString());
                        if (mnpass_res.Code == 200)
                        {
                            messenge = "Thêm MK rút tiền thành công!";
                            dataGridView.Invoke(new Action(() =>
                            {
                                dataGridView.Rows[index].Cells["col_status"].Value = messenge;
                                dataGridView.Refresh(); // Cập nhật giao diện người dùng
                            }));
                            Task.Delay(500).Wait();
                            messenge = "Đang thêm bank...";
                            dataGridView.Invoke(new Action(() =>
                            {
                                dataGridView.Rows[index].Cells["col_status"].Value = messenge;
                                dataGridView.Refresh(); // Cập nhật giao diện người dùng
                            }));
                            request.AddHeader("Referer", "https://789win19.com/WithdrawApplication");
                            string addbank_body = "{\"account\":\"" + user.bank_account + "\",\"province\":\"-\",\"city\":\"HA NOI\",\"groupBankId\":" + bank_id + ",\"memo\":null}";
                            request.AddHeader("Authorization", $"Bearer {access_token}");
                            HttpResponse addbank_response = request.Post("https://789win19.com/api/1.0/bank/add", addbank_body, "application/json");
                            RegisterResponse addbank_res = JsonConvert.DeserializeObject<RegisterResponse>(addbank_response.ToString());
                            if (addbank_res.Code == 200)
                            {
                                messenge = "Đăng ký xong! Thêm bank thành công";
                                dataGridView.Invoke(new Action(() =>
                                {
                                    dataGridView.Rows[index].Cells["col_status"].Value = messenge;
                                    dataGridView.Refresh(); // Cập nhật giao diện người dùng
                                }));
                                HttpResponse info_response = request.Get("https://789win19.com/api/1.0/user/info");
                                InfoResponse info_res = JsonConvert.DeserializeObject<InfoResponse>(info_response.ToString());
                                if (info_res.Code == 200)
                                {
                                    user.balance = info_res.Result.Balance;
                                    user.ip_address = info_res.Result.IP;
                                    user.bank_name = bank_name;
                                    user.token = access_token;
                                    user.status = messenge;
                                    dataGridView.Invoke(new Action(() =>
                                    {
                                        dataGridView.Rows[index].Cells["col_ipAddress"].Value = info_res.Result.IP;
                                        dataGridView.Rows[index].Cells["col_balance"].Value = info_res.Result.Balance;
                                        dataGridView.Refresh(); // Cập nhật giao diện người dùng
                                    }));
                                    SqliteSupport.InsertData(user);
                                }
                                else
                                {
                                    messenge = "Lỗi kiểm tra info";
                                    dataGridView.Invoke(new Action(() =>
                                    {
                                        dataGridView.Rows[index].Cells["col_status"].Value = messenge;
                                        dataGridView.Refresh(); // Cập nhật giao diện người dùng
                                    }));
                                    SqliteSupport.InsertData(user);
                                }
                            }
                            else
                            {
                                messenge = "Thêm bank không thành công! Vui lòng kiểm tra lại";
                                dataGridView.Invoke(new Action(() =>
                                {
                                    dataGridView.Rows[index].Cells["col_status"].Value = messenge;
                                    dataGridView.Refresh(); // Cập nhật giao diện người dùng
                                }));
                                user.token = access_token;
                                user.status = messenge;
                                SqliteSupport.InsertData(user);
                            }
                        }
                        else
                        {
                            messenge = "Thêm MK rút tiền không thành công! Vui lòng kiểm tra lại";
                            dataGridView.Invoke(new Action(() =>
                            {
                                dataGridView.Rows[index].Cells["col_status"].Value = messenge;
                                dataGridView.Refresh(); // Cập nhật giao diện người dùng
                            }));
                            user.token = access_token;
                            user.status = messenge;
                            SqliteSupport.InsertData(user);
                        }
                    }
                    else
                    {
                        messenge = "Đăng ký không thành công! Vui lòng kiểm tra lại";
                        dataGridView.Invoke(new Action(() =>
                        {
                            dataGridView.Rows[index].Cells["col_status"].Value = messenge;
                            dataGridView.Refresh(); // Cập nhật giao diện người dùng
                        }));
                        user.token = access_token;
                        user.status = messenge;
                        SqliteSupport.InsertData(user);
                    }
                }
                else
                {
                    messenge = reg_res.Error[0].Message;
                    dataGridView.Invoke(new Action(() =>
                    {
                        dataGridView.Rows[index].Cells["col_status"].Value = messenge;
                        dataGridView.Refresh(); // Cập nhật giao diện người dùng
                    }));
                    user.token = access_token;
                    user.status = messenge;
                    SqliteSupport.InsertData(user);
                }
            }
        }
    }
}
