using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Client
{
    internal class GameHandler
    {
        
        public GameHandler(RestClient gameClient, RestClient restClient, Main mainForm, GameRequestType gameRequestType)
        {
            this.gameClient = gameClient;
            this.restClient = restClient;
            this.mainForm = mainForm;
            this.gameRequestType = gameRequestType;
            GameClick();
        }

        RestClient gameClient;
        RestClient restClient;
        Main mainForm;
        GameRequestType gameRequestType;

        private void GameClick()
        {
            switch (gameRequestType)
            {
                case GameRequestType.GET:
                    //UpdateCurrentGameInfo();
                    break;
                case GameRequestType.PUT:
                    break;
                case GameRequestType.POST:
                    //PostLog();
                    break;
                default:
                    break;
            }
        }

        void PostLog()
        {
            RestRequest request = new RestRequest();


            request.AddParameter("user_id", CurrentUser.Id);
            request.AddParameter("game_id", CurrentGame.ID);
            request.AddParameter("win", mainForm.correct ? "yes" : "no");
            
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
                        

                        mainForm.RefreshUserData();
                        mainForm.RefreshLabels(CurrentUser.username);

                        MessageBox.Show(res.message);
                        mainForm.ShowLoggedInUserInfo();
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


        //void UpdateCurrentGameInfo()
        //{
        //    RestRequest request = new RestRequest();
        //    try
        //    {
        //        RestResponse response = gameClient.Get(request);
        //        if (response.StatusCode != System.Net.HttpStatusCode.OK)
        //        {
        //            MessageBox.Show(response.StatusDescription);
        //        }
        //        else
        //        {
        //            GameResponse res = gameClient.Deserialize<GameResponse>(response).Data;
        //            List<Game> games = res.Games;

        //            Game game = games.First();

        //            CurrentGame.ID = game.ID;
        //            CurrentGame.Name = game.Name;
        //            CurrentGame.PriceToPlay = game.PriceToPlay;
        //            CurrentGame.Reward = game.Reward;
                    
        //        }
        //    }
        //    catch (Exception e)
        //    {

        //        MessageBox.Show(e.Message);
        //    }

        //}




    }
}
