using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Newtonsoft.Json;
using Leaf.xNet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using System.Threading;

namespace RegAccGame
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            //dataGridView.DataSource = SqliteSupport.DisplayData();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("TEST");
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Task t = new Task(() =>
            {
                this.Invoke(new Action(() =>
                {
                    dataGridView.Rows.Clear();
                    string captchaKey = tb_2captchaKey.Text;
                    List<UserInfo> users = AddAccount();
                    List<AccountSupport> acc_ = new List<AccountSupport>();
                    for (int i = 0; i < users.Count; i++)
                    {
                        dataGridView.Rows.Add(i + 1, users[i].username, users[i].password, users[i].wr_password);
                    }
                    int numTasks = (int)nm_thread.Value;
                    Task[] tasks = new Task[numTasks];
                    for (int taskIndex = 0; taskIndex < numTasks; taskIndex++)
                    {
                        int startingIndex = taskIndex;
                        tasks[taskIndex] = new Task(() =>
                        {
                            for (int i = startingIndex; i < users.Count; i += numTasks)
                            {
                                //Task.Delay(TimeSpan.FromSeconds(1)).Wait();                             
                                dataGridView.Rows[i].Cells["col_status"].Value = "Đang xử lý...";
                                AccountSupport account = new AccountSupport(dataGridView);
                                account.index = i;
                                if (rb_mbbank.Checked)
                                {
                                    account.bank_id = "13";
                                    account.bank_name = "MB BANK";
                                }
                                else
                                {
                                    string[] bankId = cb_listBank.SelectedItem.ToString().Split('|');
                                    account.bank_id = bankId[0];
                                    account.bank_id = bankId[1];
                                }
                                account.captcha_key = captchaKey;
                                account.user_agent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/121.0.0.0 Safari/537.36 Edg/121.0.0.0";
                                account.Register(users[i]);
                                Task.Delay(500).Wait();
                            }
                        });
                        tasks[taskIndex].Start();
                    }
                }));
            });
            t.Start();
        }
        public List<UserInfo> AddAccount()
        {
            List<string> account = File.ReadAllLines("./Data/input.txt").ToList();
            List<UserInfo> users = new List<UserInfo>();
            foreach (var line in account)
            {
                string[] a = line.Split('|');
                UserInfo user = new UserInfo();
                user.phone_number = a[0];
                user.username = a[1];
                user.password = a[2];
                user.wr_password = a[3];
                user.fullname = a[4];
                user.bank_account = a[5];
                users.Add(user);
            }
            return users;
        }
        private void cb_listBank_Click(object sender, EventArgs e)
        {
            AccountSupport account = new AccountSupport(dataGridView);
            Task t = new Task(() =>
            {
                this.Invoke(new Action(() =>
                {
                    cb_listBank.Items.AddRange(account.GetListBank().ToArray());
                }));
            });
            t.Start();
        }
    }
}
