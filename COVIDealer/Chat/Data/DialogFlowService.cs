using System.Threading.Tasks;
using Google.Cloud.Dialogflow.V2;

namespace COVIDealer.Chat
{
    internal class DialogFlowService
    {
        private string _userID;
        private string _projectId;
        private SessionsClient _sessionsClient;
        private SessionName _sessionName;

        public DialogFlowService(string userID, string projectId)
        {

            _userID = userID;
            _projectId = projectId;

        }

        private async Task CreateSession()
        {
            // Create client
            SessionsClientBuilder builder = new SessionsClientBuilder();
            builder.CredentialsPath = "dialogflow_service_account.json";
            _sessionsClient = await builder.BuildAsync();
            // Initialize request argument(s)
            _sessionName = new SessionName(_projectId, _userID);

        }

        public async Task<QueryResult> CheckIntent(string userInput, string LanguageCode = "en")
        {
            await CreateSession();
            QueryInput queryInput = new QueryInput();
            var queryText = new TextInput();
            queryText.Text = userInput;
            queryText.LanguageCode = LanguageCode;
            queryInput.Text = queryText;

            // Make the request
            DetectIntentResponse response = await _sessionsClient.DetectIntentAsync(_sessionName, queryInput);
            return response.QueryResult;
        }
    }
}
