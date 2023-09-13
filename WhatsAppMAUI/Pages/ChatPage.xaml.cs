using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using WhatsAppMAUI.Models;

namespace WhatsAppMAUI.Pages;

public partial class ChatPage : ContentPage
{

    public ChatPage()
    {
        InitializeComponent();
        Chats = new ObservableCollection<ChatModel>(LoadChats());

        BindingContext = this;
    }
    public ObservableCollection<ChatModel> Chats { get; set; }

    private static IEnumerable<ChatModel> LoadChats()
    {
        var listOfChats = new List<ChatModel>();
        string api = "https://thesimpsonsquoteapi.glitch.me/quotes?count=30";

        using (HttpClient client = new HttpClient())
        {
            var response = client.GetStringAsync(api);
            response.Wait();

            var jsonResponse = JsonConvert.DeserializeObject<ResponseApi[]>(response.Result).ToList();
            foreach (var item in jsonResponse)
            {
                var itemChat = new ChatModel(item.image, item.character, item.quote, DateTime.Now, 0);
                listOfChats.Add(itemChat);
            }
        }
        return listOfChats;
    }

    private void CollectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {

    }
}