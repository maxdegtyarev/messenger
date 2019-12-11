using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

//Request library
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace messengerApplication
{
    class ClientSystem
    {

        //Данные поля хранят основную информацию для доступа
        private string secretHash;
        private string cachedName;
        private string cachedPassword;

        //Хранит авторизованный аккаунт
        private Account authorizedAccount;

        //Настройки клиента
        private const string serverAddr = "http://localhost:3000";

        public static string ServerAddr => serverAddr;
        public Account AuthorizedAccount { get => authorizedAccount; set => authorizedAccount = value; }
        public string SecretHash { get => secretHash; set => secretHash = value; }
        public string CachedName { get => cachedName; set => cachedName = value; }
        public string CachedPassword { get => cachedPassword; set => cachedPassword = value; }

        public ClientSystem()
        {
        
        }

        public async Task<bool> checkHash(string accHash)
        {
            string jsonRequest = "{\"accHash\" : \"" + accHash + "\"}";
            string result = await PostAsync(ServerAddr + "/account/check", jsonRequest, "application/json", "POST");

            JObject jObject = JObject.Parse(result);

            if ((int)jObject["id"] == 0)
            {
                return (bool)jObject["message"]["exists"];
            } else
            {
                return false;
            }
            
        }

        public async Task<LinkedList<Account>> GetAccounts(string accHash)
        {
            string jsonRequest = "{\"accHash\" : \"" + accHash + "\"}";

            string result = await PostAsync(ServerAddr + "/account/list", jsonRequest, "application/json", "POST");
            JObject jObject = JObject.Parse(result);

            if ((int)jObject["id"] == 0)
            {
                string resArray = jObject["message"].ToString();

                JArray array = JArray.Parse(resArray);
                LinkedList<Account> accounts = new LinkedList<Account>();

                for (int i = 1; i < array.Count; i++)
                {
                    accounts.AddLast(new Account(
                            (int)array[i]["accId"],
                            (string)array[i]["accName"],
                            (string)array[i]["accSurname"],
                            (string)array[i]["accBirth"]
                         ));
                }

                return accounts;
            }

            return null;
        }

        public async Task<LinkedList<KeyValuePair<Account, Account>>> GetMessageList(string accHash)
        {
            string jsonRequest = "{\"mSender\" : \"" + accHash + "\"}";

            string result = await PostAsync(ServerAddr + "/account/contact/activelist", jsonRequest, "application/json", "POST");
            JObject jObject = JObject.Parse(result);

            if ((int)jObject["id"] == 0)
            {
                string resArray = jObject["message"].ToString();
                
                JArray array = JArray.Parse(resArray);
                LinkedList<KeyValuePair<Account, Account>> accounts = new LinkedList<KeyValuePair<Account, Account>>();

                for (int i = 1; i < array.Count; i++)
                {
                    accounts.AddLast(new KeyValuePair<Account, Account>(
                        new Account(
                            (int)array[i]["mSender"],
                            (string)array[i]["mSenderName"],
                            (string)array[i]["mSenderSurname"]
                              ),
                        new Account(
                            (int)array[i]["mReceiver"],
                            (string)array[i]["mReceiverName"],
                            (string)array[i]["mReceiverSurname"]
                        )));
                }

                return accounts;
            }

            return null;
        }

        public async Task<Contact> writeContact(string accFrom, int accTo)
        {
            string jsonRequest = "{\"conFrom\" : \"" + accFrom + "\", \"conTo\" : " + accTo.ToString() + "}";

            string result = await PostAsync(ServerAddr + "/account/contact/add", jsonRequest, "application/json", "POST");
            JObject jObject = JObject.Parse(result);

            if ((int)jObject["id"] == 0)
            {
                string nextStep = jObject["message"].ToString();

                if (nextStep == "null")
                {
                    return null;
                }
                else
                {
                    Contact contact = JsonConvert.DeserializeObject<Contact>(nextStep);
                    return contact;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<LinkedList<Account>> GetContacts(string accFrom)
        {
            
            string jsonRequest = "{\"conFrom\" : \"" + accFrom + "\"}";

            string result = await PostAsync(ServerAddr + "/account/contact/list", jsonRequest, "application/json", "POST");
            JObject jObject = JObject.Parse(result);

            if ((int)jObject["id"] == 0)
            {
                string resArray = jObject["message"].ToString();

                JArray array = JArray.Parse(resArray);
                LinkedList<Account> accounts = new LinkedList<Account>();

                for (int i = 1; i < array.Count; i++)
                {
                    accounts.AddLast(new Account(
                            (int)array[i]["accId"],
                            (string)array[i]["accName"],
                            (string)array[i]["accSurname"],
                            (string)array[i]["accBirth"]
                         ));
                }

                return accounts;
            }

            return null;
        }

        public async Task<LinkedList<Message>> getPrivateMessageList(int mReceiver, string accHash)
        {
            string jsonRequest = "{\"mReceiver\" : \"" + mReceiver.ToString() + "\", \"mSender\" : \""+ accHash + "\"}";
            string result = await PostAsync(ServerAddr + "/message/list", jsonRequest, "application/json", "POST");

            JObject jObject = JObject.Parse(result);

            if ((int)jObject["id"] == 0)
            {
                string resArray = jObject["message"].ToString();

                JArray array = JArray.Parse(resArray);
                LinkedList<Message> messages = new LinkedList<Message>();

                for (int i = 1; i < array.Count; i++)
                {
                    messages.AddLast(new Message(
                            (string)array[i]["mSender"],
                            (string)array[i]["mReceiver"],
                            (string)array[i]["mText"],
                            (string)array[i]["mDate"]
                        ));
                }

                return messages;
            }

            return null;
        }

        public async Task<LinkedList<Message>> getUnreadPrivateMessageList(int mSender, string accHash)
        {
            string jsonRequest = "{\"mReceiver\" : \"" + mSender.ToString() + "\", \"mSender\" : \"" + accHash + "\"}";
            string result = await PostAsync(ServerAddr + "/message/unread", jsonRequest, "application/json", "POST");

            JObject jObject = JObject.Parse(result);

            if ((int)jObject["id"] == 0)
            {
                string resArray = jObject["message"].ToString();

                JArray array = JArray.Parse(resArray);
                LinkedList<Message> messages = new LinkedList<Message>();

                for (int i = 1; i < array.Count; i++)
                {
                    messages.AddLast(new Message(
                            (string)array[i]["mSender"],
                            (string)array[i]["mReceiver"],
                            (string)array[i]["mText"],
                            (string)array[i]["mDate"]
                        ));
                }

                return messages;
            }

            return null;
        }

        public async Task<bool> updateAccount(string accName, string accSurname, string accHash)
        {
            string jsonRequest = "{\"accName\":\" " + accName + "\", \"accSurname\":\" " +accSurname + "\",  \"accHash\" : \"" + accHash + "\"}";
            string result = await PostAsync(ServerAddr + "/account/update", jsonRequest, "application/json", "POST");

            JObject jObject = JObject.Parse(result);

            if ((int)jObject["id"] == 0)
            {
                return true;
            }

            return false;
        }

        public async Task<bool> sendPrivateMessage(int mReceiver, string mText, string accHash)
        {
            string jsonRequest = "{\"mReceiver\" : " + mReceiver.ToString() + ", \"mText\": \""+ mText +"\", \"mSender\" : \"" + accHash + "\"}";
            string result = await PostAsync(ServerAddr + "/message/add", jsonRequest, "application/json", "POST");

            JObject jObject = JObject.Parse(result);

            if ((int)jObject["id"] == 0)
            {
                return true;
            }

            return false;
        }

        public async Task<LinkedList<Notification>> getAvailableNotificationList(string accHash)
        {
            string jsonRequest = "{\"accHash\" : \"" + accHash + "\"}";
            string result = await PostAsync(ServerAddr + "/account/notification/list", jsonRequest, "application/json", "POST");

            JObject jObject = JObject.Parse(result);

            if ((int)jObject["id"] == 0)
            {
                string resArray = jObject["message"].ToString();

                LinkedList<Notification> notifications = new LinkedList<Notification>();
                JArray array = JArray.Parse(resArray);

                for (int i = 1; i < array.Count; i++)
                {
                    notifications.AddLast(new Notification((string)array[i]["notText"]));
                }

                return notifications;
            }

            return null;
        }

        public async Task<string> registerAccountAsync(string accLogin, string accName, string accSurname, string accBirth, string accPassword)
        {
            Account account = new Account(accLogin, accName, accSurname, accBirth, accPassword);
            string jsonRequest = JsonConvert.SerializeObject(account);

            string result = await PostAsync(ServerAddr + "/account/add", jsonRequest, "application/json", "POST");
            return result;
        }


        public async Task<string> authAccount(string accLogin, string accPassword)
        {
            Account account = new Account(accLogin, accPassword);
            string jsonRequest = JsonConvert.SerializeObject(account);

            string result = await PostAsync(ServerAddr + "/account/auth", jsonRequest, "application/json", "POST");


            return result;
        }


        private string Get(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        private async Task<string> GetAsync(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return await reader.ReadToEndAsync();
            }
        }

        private string Post(string uri, string data, string contentType, string method = "POST")
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);

            HttpWebRequest request = HttpWebRequest.Create(uri) as HttpWebRequest;

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.ContentLength = dataBytes.Length;
            request.ContentType = contentType;
            request.Method = method;
            request.ProtocolVersion = HttpVersion.Version11;

            using (Stream requestBody = request.GetRequestStream())
            {
                requestBody.Write(dataBytes, 0, dataBytes.Length);
            }

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())

                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }

            catch (WebException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
                
            }

            return string.Empty;
        }

        private async Task<string> PostAsync(string uri, string data, string contentType, string method = "POST")
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.ContentLength = dataBytes.Length;
            request.ContentType = contentType;
            request.Method = method;

            using (Stream requestBody = request.GetRequestStream())
            {
                await requestBody.WriteAsync(dataBytes, 0, dataBytes.Length);
            }

            using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}
