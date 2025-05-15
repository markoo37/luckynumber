using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace Client
{
    public partial class Main : Form
    {
        public bool correct = false;
        public bool handlerOpened = false;

        public Main()
        {
            InitializeComponent();

            InitializeUsersDataGridView();
            RefreshUserData();
            IsLoggedIn();
        }

        RestClient restClient = new RestClient("http://localhost:3000/users");
        RestClient loginClient = new RestClient("http://localhost:3000/login");
        RestClient gameClient = new RestClient("http://localhost:3000/game");

        bool IsLoggedIn()
        {
            if (CurrentUser.username == null)
            {
                ManageButtons(false);
                GameResetButtonVisibility(false);
                new UserHandler(loginClient, this, RequestType.LOGIN).Show();

                return false;
            }
            return true;
        }

        void InitializeUsersDataGridView()
        {
            usersData.Columns.Add("rank", "Rank");

            usersData.Columns.Add("username", "Username");
            usersData.Columns.Add("how_many_wins", "Wins");
            usersData.Columns.Add("id", "ID");


        }


        public void RefreshUserData()
        {
            RestRequest request = new RestRequest();
            try
            {
                RestResponse response = restClient.Get(request);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(response.StatusDescription);
                }
                else
                {
                    Response res = restClient.Deserialize<Response>(response).Data;
                    List<User> users = res.Users;
                    users = users.Where(x => x.user_type_id != 2).OrderByDescending(x => x.how_many_wins).ToList();
                    usersData.Rows.Clear();
                    int rank = 1;
                    foreach (var user in users)
                    {

                        usersData.Rows.Add(rank, user.username, user.how_many_wins, user.ID);
                        rank++;
                    }
                    
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void RefreshLabels(string username)
        {
            RestRequest request = new RestRequest();
            try
            {
                RestResponse response = restClient.Get(request);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(response.StatusDescription);
                }
                else
                {
                    Response res = restClient.Deserialize<Response>(response).Data;
                    List<User> users = res.Users;
                    List<User> correctUser = users.Where(x => x.username == username).ToList();
                    User user = correctUser.First();
                    CurrentUser.Id = user.ID;
                    CurrentUser.balance = user.balance;
                    CurrentUser.how_many_wins = user.how_many_wins;
                    CurrentUser.user_type_id = user.user_type_id;
                }

                RestResponse responseGame = gameClient.Get(request);
                if (responseGame.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(responseGame.StatusDescription);
                }
                else
                {
                    GameResponse res = gameClient.Deserialize<GameResponse>(responseGame).Data;
                    List<Game> games = res.Games;
                    Game game = games.First();
                    CurrentGame.ID = game.game_id;
                    CurrentGame.Name = game.name;
                    CurrentGame.PriceToPlay = game.price_to_play;
                    CurrentGame.Reward = game.reward;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void ShowLoggedInUserInfo()
        {
            currentUserLabel.Text = CurrentUser.username;
            winsLabel.Text = CurrentUser.how_many_wins.ToString();
            balanceLabel.Text = CurrentUser.balance.ToString();

            if (CurrentUser.user_type_id == 2)
            {
                adminLabel.Visible = true;
                deleteUser.Visible = true;
                winsLabel.Visible = false;
                gyozelmek.Visible = false;
                panel1.Visible = false;
                uploadMoney.Visible = false;
                balanceLabel.Visible = false;
                hufLabel.Visible = false;
            }
            else
            {
                adminLabel.Visible = false;
                deleteUser.Visible = false;
                winsLabel.Visible = true;
                gyozelmek.Visible = true;
            }

        }



        public void logoutButton_Click(object sender, EventArgs e)
        {
            CurrentUser.username = null;


            currentUserLabel.Text = "-";
            winsLabel.Text = "-";
            balanceLabel.Text = "-";


            List<Label> labels = new List<Label>();

            labels.Add(no1);
            labels.Add(no2);
            labels.Add(no3);
            labels.Add(no4);
            labels.Add(no5);
            labels.Add(no6);
            labels.Add(no7);
            labels.Add(no8);
            labels.Add(no9);

            foreach (var label in labels)
            {
                label.Visible = true;
            }



            ManageButtons(false);
            GameResetButtonVisibility(false);
            adminLabel.Visible = false;
            deleteUser.Visible = false;
            panel1.Visible = true;
            uploadMoney.Visible = true;
            balanceLabel.Visible = true;
            hufLabel.Visible = true;

            successLabel.Visible = false;
            lossLabel.Visible = false;

            new UserHandler(loginClient, this, RequestType.LOGIN).Show();
        }



        public void loginButton_Click(object sender, EventArgs e)
        {
            if (!handlerOpened)
            {

                new UserHandler(loginClient, this, RequestType.LOGIN).Show();
            }



        }

        private void Main_Load(object sender, EventArgs e)
        {
            new GameHandler(gameClient, restClient, this, GameRequestType.GET);
        }

        private void uploadMoney_Click(object sender, EventArgs e)
        {
            if (IsLoggedIn())
            {
                
                new UserHandler(restClient, this, RequestType.PUT).Show();
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            if (!handlerOpened)
            {
                new UserHandler(restClient, this, RequestType.POST).Show();
            }

        }

        public void ManageButtons(bool enable)
        {
            gameButton.Enabled = enable;
            gameResetButton.Enabled = !enable;
            logoutButton.Enabled = enable;
            loginButton.Enabled = !enable;
            uploadMoney.Enabled = enable;
            registrationButton.Enabled = !enable;

        }

        private void gameButton_Click(object sender, EventArgs e)
        {
            if (CurrentUser.balance < 500)
            {
                MessageBox.Show("Nincs elég fedezet!");
            }
            else
            {
                if (numberBox.Text != "Számok")
                {
                    numberBox.Enabled = false;
                    gameButton.Enabled = false;
                    gameResetButton.Enabled = true;
                    List<Label> labels = new List<Label>();

                    labels.Add(no1);
                    labels.Add(no2);
                    labels.Add(no3);
                    labels.Add(no4);
                    labels.Add(no5);
                    labels.Add(no6);
                    labels.Add(no7);
                    labels.Add(no8);
                    labels.Add(no9);

                    foreach (var label in labels)
                    {
                        label.Visible = true;
                    }

                    Random rnd = new Random();
                    int winnerNum = rnd.Next(1, 10);



                    for (int i = 0; i < labels.Count; i++)
                    {
                        if (labels[i].Text != winnerNum.ToString())
                        {
                            labels[i].Visible = false;
                        }
                    }

                    if (winnerNum == int.Parse(numberBox.Text))
                    {
                        correct = true;
                        PostLog();
                        UpdateUserMoney(correct);
                        successLabel.Visible = true;
                        //MessageBox.Show("Győzelem!");

                    }
                    else
                    {
                        correct = false;
                        PostLog();
                        UpdateUserMoney(correct);
                        lossLabel.Visible = true;
                        //MessageBox.Show("Ez most nem sikerült!");
                    }
                }
                else
                {
                    MessageBox.Show("Válasszon ki számot!");
                }
            }



        }

        private void UpdateUserMoney(bool correct)
        {
            RestRequest request = new RestRequest();
            request.AddBody(new
            {
                id = CurrentUser.Id,
                money = correct ? (CurrentGame.Reward-CurrentGame.PriceToPlay) : -(CurrentGame.PriceToPlay),
                win = correct ? "yes" : "no"
            });
            try
            {
                RestResponse response = gameClient.Put(request);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(response.StatusDescription);
                }
                else
                {
                    Response res = gameClient.Deserialize<Response>(response).Data;
                    if (res.error == 0)
                    {


                        RefreshUserData();
                        RefreshLabels(CurrentUser.username);
                        ShowLoggedInUserInfo();

                        //MessageBox.Show(res.message);



                    }
                    else
                    {
                        //MessageBox.Show(res.message);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void gameResetButton_Click(object sender, EventArgs e)
        {
            successLabel.Visible = false;
            lossLabel.Visible = false;

            correct = false;
            numberBox.Enabled = true;
            numberBox.Text = "Számok";
            List<Label> labels = new List<Label>();

            labels.Add(no1);
            labels.Add(no2);
            labels.Add(no3);
            labels.Add(no4);
            labels.Add(no5);
            labels.Add(no6);
            labels.Add(no7);
            labels.Add(no8);
            labels.Add(no9);

            foreach (var label in labels)
            {
                label.Visible = true;
            }

            gameButton.Enabled = true;
            gameResetButton.Enabled = false;
        }

        public void GameResetButtonVisibility(bool enable)
        {
            gameResetButton.Enabled = enable;
        }

        private void senddata_Click(object sender, EventArgs e)
        {
            
        }


        public void PostLog()
        {
            RestRequest request = new RestRequest();

            request.AddBody(new
            {
                user_id = CurrentUser.Id,
                game_id = CurrentGame.ID,
                win = correct ? "yes" : "no",
                date = DateTime.Now.ToString("G"),
            });

            //request.AddParameter("user_id", CurrentUser.Id);
            //request.AddParameter("game_id", CurrentGame.ID);
            //request.AddParameter("win", correct ? "yes" : "no");

            try
            {
                RestResponse response = gameClient.Post(request);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(response.StatusDescription);
                }
                else
                {
                    Response res = restClient.Deserialize<Response>(response).Data;
                    if (res.error == 0)
                    {


                        //RefreshUserData();
                        //RefreshLabels(CurrentUser.username);

                        //MessageBox.Show(res.message);
                        //ShowLoggedInUserInfo();
                    }
                    else
                    {
                        MessageBox.Show(res.message);
                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        public void CheckIfAdmin()
        {
            if (CurrentUser.user_type_id == 2)
            {
                gameButton.Enabled = false;
                gameResetButton.Enabled = false;
                uploadMoney.Enabled = false;
            }
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            if (IsLoggedIn())
            {
                new UserHandler(restClient, this, RequestType.DELETE).Show();
            }
        }

        private void usersData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            

            foreach (DataGridViewRow row in usersData.Rows)
            {
                
                int rank = Convert.ToInt32(row.Cells[1].Value);

                if (rank == 1)
                {
                    row.DefaultCellStyle.BackColor = Color.Gold;
                }
                if (rank == 2)
                {
                    row.DefaultCellStyle.BackColor = Color.Silver;
                }
                if (rank == 3)
                {
                    row.DefaultCellStyle.BackColor = Color.SaddleBrown;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
            
        }
    }
}
