using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace Client
{
    public partial class UserHandler : Form
    {

        
        public UserHandler(RestClient restClient, Main mainForm, RequestType requestType)
        {
            
            InitializeComponent();
            this.restClient = restClient;
            this.mainForm = mainForm;
            this.requestType = requestType;
            SetFormElements();
            mainForm.handlerOpened = true;
        }

        void SetFormElements()
        {
            switch (requestType)
            {
                case RequestType.POST:
                    infoOfWindow.Text = "Regisztáció";
                    idLabel.Visible = false;
                    idBox.Visible = false;
                    addMoneyLabel.Visible = false;
                    addMoneyBox.Visible = false;                    
                    userHandlerButton.Text = "ADD";
                    break;
                case RequestType.PUT:
                    infoOfWindow.Text = "Feltöltés";
                    passwordLabel.Visible = false;  
                    passwordBox.Visible = false;

                    idLabel.Visible = false;
                    idBox.Visible = false;
                    idBox.Text = CurrentUser.Id.ToString();

                    usernameLabel.Visible = false;
                    usernameBox.Visible = false;
                    usernameBox.Text = CurrentUser.username;



                    userHandlerButton.Text = "UPDATE";
                    break;
                case RequestType.DELETE:
                    infoOfWindow.Text = "Törlés";
                    passwordLabel.Visible = false;  
                    passwordBox.Visible = false;
                    addMoneyLabel.Visible = false;
                    addMoneyBox.Visible = false;
                    userHandlerButton.Text = "DELETE";
                    break;
                case RequestType.LOGIN:
                    infoOfWindow.Text = "Bejelentkezés";
                    idBox.Visible = false;
                    idLabel.Visible = false;
                    addMoneyBox.Visible=false;
                    addMoneyLabel.Visible=false;
                    userHandlerButton.Text = "LOGIN";
                    break;
                default:
                    break;
            }
        }

        RestClient restClient;
        Main mainForm;
        RequestType requestType;

        private void userHandlerButton_Click(object sender, EventArgs e)
        {
            switch (requestType)
            {
                case RequestType.POST:
                    AddUser();
                    
                    break;
                case RequestType.PUT:
                    
                    AddMoney();
                    
                    break;
                case RequestType.DELETE:
                    DeleteUser();
                    break;
                case RequestType.LOGIN:
                    LoginUser();
                    mainForm.handlerOpened = false;
                    break;
                case RequestType.LOGOUT:
                default:
                    break;
            }
        }

        private List<User> CheckCurrentUsers()
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
                    List<User> users = res.Users.Where(x => x.ID != 2).ToList();
                    return users;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return new List<User>();
        }


        private void DeleteUser()
        {
            //List<User> currentUsers = CheckCurrentUsers();

            //if (currentUsers.Count == 0)
            //{
            //    MessageBox.Show("No users to delete!");
            //    return;
            //}

            //List<User> correctUser = currentUsers.Where(x => x.username == usernameBox.Text && x.ID == int.Parse(idBox.Text)).ToList();
            //User user = correctUser.First();

            RestRequest request = new RestRequest();
            request.AddBody(new
            {
                id = idBox.Text,
                username = usernameBox.Text,
            });
            try
            {
                RestResponse response = restClient.Delete(request);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(response.StatusDescription);
                }
                else
                {
                    Response res = restClient.Deserialize<Response>(response).Data;
                    if (res.error == 0)
                    {
                        

                        mainForm.RefreshUserData();
                        mainForm.RefreshLabels(CurrentUser.username);
                        mainForm.ShowLoggedInUserInfo();

                        MessageBox.Show(res.message);

                        mainForm.ManageButtons(true);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(res.message);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        void LogoutUser()
        {
            CurrentUser.username = null;
            CurrentUser.password = null;
            CurrentUser.balance = 0;
            CurrentUser.how_many_wins = 0;
            CurrentUser.user_type_id = 0;
            
        }

        void AddMoney()
        {
            RestRequest request = new RestRequest();
            request.AddBody(new
            {
                id = idBox.Text,
                username = usernameBox.Text,
                balance = addMoneyBox.Text
            });
            try
            {
                RestResponse response = restClient.Put(request);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(response.StatusDescription);
                }
                else
                {
                    Response res = restClient.Deserialize<Response>(response).Data;
                    if (res.error == 0)
                    {
                        CurrentUser.balance += int.Parse(addMoneyBox.Text);

                        mainForm.RefreshUserData();
                        mainForm.RefreshLabels(CurrentUser.username);
                        mainForm.ShowLoggedInUserInfo();

                        MessageBox.Show(res.message);
                        
                        mainForm.ManageButtons(true);
                        
                        this.Close();
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


        void LoginUser()
        {
            RestRequest request = new RestRequest();
            request.AddBody(new
            {
                username = usernameBox.Text,
                password = passwordBox.Text
            });
            //request.AddParameter("username", usernameBox.Text);
            //request.AddParameter("password", passwordBox.Text);
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
                    if (res.error == 0)
                    {
                        CurrentUser.username = usernameBox.Text;
                        CurrentUser.password = passwordBox.Text;

                        mainForm.RefreshUserData();
                        mainForm.RefreshLabels(CurrentUser.username);

                        MessageBox.Show(res.message);
                        
                        mainForm.ShowLoggedInUserInfo();
                        mainForm.ManageButtons(true);
                        mainForm.GameResetButtonVisibility(true);
                        mainForm.CheckIfAdmin();

                        this.Close();
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

        void AddUser()
        {
            RestRequest request = new RestRequest();
            request.AddParameter("username", usernameBox.Text);
            request.AddParameter("password", passwordBox.Text);
            try
            {
                RestResponse response = restClient.Post(request);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(response.StatusDescription);
                }
                else
                {
                    Response res = restClient.Deserialize<Response>(response).Data;
                    if (res.error == 0)
                    {
                        CurrentUser.username = usernameBox.Text;
                        CurrentUser.password = passwordBox.Text;

                        mainForm.RefreshUserData();
                        mainForm.RefreshLabels(CurrentUser.username);

                        MessageBox.Show(res.message);
                        mainForm.ShowLoggedInUserInfo();
                        mainForm.ManageButtons(true);
                        this.Close();
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            mainForm.handlerOpened = false;
            this.Close();            
        }
    }
}
