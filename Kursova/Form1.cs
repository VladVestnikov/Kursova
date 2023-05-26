using Kursova.Class;

namespace Kursova
{
    public partial class Form1 : Form
    {
      
        public static RegistrUser registrUser = null;
        public static UserRepos userRepos = null;

        public Action<string> DataEntered { get; internal set; }

        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
            Storage.Instance.form1 = this;
        }
        private void InitializeComboBox()
        {
            RagAndLog.Items.Add("Вхід");
            RagAndLog.Items.Add("Реєстрація");     
            // Добавьте другие опции, если необходимо
        }

        private void buttonLogaut_Click(object sender, EventArgs e)
        {
            var Log = new Log();
            this.Close();
            Log.Hide();
        }

        private void RagAndLog_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = RagAndLog.SelectedItem.ToString();
            switch (selectedOption)
            {
                case "Вхід":
                    Log form2 = new Log();
                    form2.Show();
                    this.Hide();
                    break;
                    
                case "Реєстрація":
                    LogForm form3 = new LogForm();
                    form3.Show();
                    this.Hide();
                    break;
                
                    
            }
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            var guest = new Guest();
            guest.Show();
            this.Hide();
        }
    }
}