namespace virtual_pet_project
{
    public partial class Form1 : Form
    {
        Cat cat = new Cat();

        public Form1()
        {
            InitializeComponent();

            updateCatPicture();

            System.Timers.Timer changeTimer = new System.Timers.Timer(20);

            changeTimer.Elapsed += changeboxes;
            changeTimer.AutoReset = true;
            changeTimer.Enabled = true;
        }

        public void changeboxes(object? sender, EventArgs e)
        {
            sleepDecreaseBox.Height = cat.Sleep;
            thirstDecreaseBox.Height = cat.Thirst;
            foodDecreaseBox.Height = cat.Hunger;
        }



        private void updateCatPicture()
        {
            CatPicture.Image = Properties.Resources.cat_idle;

        }

        private void foodButton_Click(object sender, EventArgs e)
        {
            cat.Hunger = cat.Hunger + 10;
        }

        private void drinkButton_Click(object sender, EventArgs e)
        {
            cat.Thirst = cat.Thirst + 10;
        }

        private void sleepButton_Click(object sender, EventArgs e)
        {
            cat.Sleep = cat.Sleep + 10;
        }
    }
}
