using System.Buffers;

namespace Transact
{
    public partial class MaxCareViewModel : ObservableObject
    {
        [ObservableProperty]
        private string searchText;

        [ObservableProperty]
        private string selectedFolder = "Empty";

        [ObservableProperty]
        private string selectedStatus = "Tất cả tính trạng";

        public ObservableCollection<FacebookAccount> Accounts { get; } = new();

        public MaxCareViewModel()
        {
            LoadAccounts();
        }

        private void LoadAccounts()
        {
            Accounts.Clear();

            // Add sample data (from your image)
            Accounts.Add(new FacebookAccount {STT = 1, UID = "1000068588...", Password = "Concept 18h...", Email = "jakaroo...", Name = "Deep Trang", Proxy = "103.12...", Folder = "Empty", LastInteraction = "", Status = "Live",OperationStatus = ""});
            Accounts.Add(new FacebookAccount {STT = 2, UID = "1000068588...", Password = "Concept 18h...", Email = "jakaroo...", Name = "Deep Trang", Proxy = "103.12...", Folder = "Empty", LastInteraction = "", Status = "Live",OperationStatus = ""});
            Accounts.Add(new FacebookAccount {STT = 3, UID = "1000068588...", Password = "Concept 18h...", Email = "jakaroo...", Name = "Deep Trang", Proxy = "103.12...", Folder = "Empty", LastInteraction = "", Status = "Live",OperationStatus = ""});
            Accounts.Add(new FacebookAccount {STT = 4, UID = "1000068588...", Password = "Concept 18h...", Email = "jakaroo...", Name = "Deep Trang", Proxy = "103.12...", Folder = "Empty", LastInteraction = "", Status = "Live",OperationStatus = ""});
            Accounts.Add(new FacebookAccount {STT = 5, UID = "1000068588...", Password = "Concept 18h...", Email = "jakaroo...", Name = "Deep Trang", Proxy = "103.12...", Folder = "Empty", LastInteraction = "", Status = "Live",OperationStatus = ""});
            Accounts.Add(new FacebookAccount {STT = 6, UID = "1000068588...", Password = "Concept 18h...", Email = "jakaroo...", Name = "Deep Trang", Proxy = "103.12...", Folder = "Empty", LastInteraction = "", Status = "Live",OperationStatus = ""});
            Accounts.Add(new FacebookAccount {STT = 7, UID = "1000068588...", Password = "Concept 18h...", Email = "jakaroo...", Name = "Deep Trang", Proxy = "103.12...", Folder = "Empty", LastInteraction = "", Status = "Live",OperationStatus = ""});
            Accounts.Add(new FacebookAccount {STT = 8, UID = "1000068588...", Password = "Concept 18h...", Email = "jakaroo...", Name = "Deep Trang", Proxy = "103.12...", Folder = "Empty", LastInteraction = "", Status = "Live",OperationStatus = ""});
            Accounts.Add(new FacebookAccount {STT = 9, UID = "1000068588...", Password = "Concept 18h...", Email = "jakaroo...", Name = "Deep Trang", Proxy = "103.12...", Folder = "Empty", LastInteraction = "", Status = "Live", OperationStatus = "" });
            Accounts.Add(new FacebookAccount {STT = 10, UID = "1000068588...", Password = "Concept 18h...", Email = "jakaroo...", Name = "Deep Trang", Proxy = "103.12...", Folder = "Empty", LastInteraction = "", Status = "Live",OperationStatus = "" });
            Accounts.Add(new FacebookAccount {STT = 11, UID = "1000068588...", Password = "Concept 18h...", Email = "jakaroo...", Name = "Deep Trang", Proxy = "103.12...", Folder = "Empty", LastInteraction = "", Status = "Live",OperationStatus = "" });
            Accounts.Add(new FacebookAccount {STT = 12, UID = "1000068588...", Password = "Concept 18h...", Email = "jakaroo...", Name = "Deep Trang", Proxy = "103.12...", Folder = "Empty", LastInteraction = "", Status = "Live", OperationStatus = "" });
            Accounts.Add(new FacebookAccount {STT = 12, UID = "6157586752...", Password = "Concept2059...", Email = "bbdej4...", Name = "Mes Lee", Proxy = "103.12...", Folder = "Empty", LastInteraction = "26/05/2025 00:06:17", Status = "Live" , OperationStatus = "" });
            Accounts.Add(new FacebookAccount {STT = 14, UID = "1000068588...", Password = "Concept 18h...", Email = "jakaroo...", Name = "Deep Trang", Proxy = "103.12...", Folder = "Empty", LastInteraction = "", Status = "Live",OperationStatus = "" });
            Accounts.Add(new FacebookAccount {STT = 15, UID = "1000068588...", Password = "Concept 18h...", Email = "jakaroo...", Name = "Deep Trang", Proxy = "103.12...", Folder = "Empty", LastInteraction = "", Status = "Live",OperationStatus = "" });
            Accounts.Add(new FacebookAccount {STT = 16, UID = "1000068588...", Password = "Concept 18h...", Email = "jakaroo...", Name = "Deep Trang", Proxy = "103.12...", Folder = "Empty", LastInteraction = "", Status = "Live",OperationStatus = "" });
            Accounts.Add(new FacebookAccount {STT = 17, UID = "1000068588...", Password = "Concept 18h...", Email = "jakaroo...", Name = "Deep Trang", Proxy = "103.12...", Folder = "Empty", LastInteraction = "", Status = "Live",OperationStatus = "" });
            Accounts.Add(new FacebookAccount {STT = 18, UID = "1000068588...", Password = "Concept 18h...", Email = "jakaroo...", Name = "Deep Trang", Proxy = "103.12...", Folder = "Empty", LastInteraction = "", Status = "Live", OperationStatus = "" });

        }

        [RelayCommand]
        private void CloseChromedriver()
        {
        }

        [RelayCommand]
        private void SyncAccounts()
        {
        }
    }
}