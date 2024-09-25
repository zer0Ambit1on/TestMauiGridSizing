namespace MAUIGridSizing
{
    public partial class MainPage : ContentPage
    {
        public List<DataTest> Items { get; set; }

        public MainPage()
        {
            Items = new List<DataTest>();
            for (int i = 0; i <= 100; i++)
            {
                Items.Add(new DataTest() { Name = "123123123123" });
            }
            InitializeComponent();
            BindingContext = this;
        }
    }
}
