namespace get.set_Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRechne_Click(object sender, EventArgs e)
        {
            // Rechteck-Objekt erzeugen 

            

            try
//versuche, diesen Code auszuführen 
           {
                Rechteck r = new Rechteck(Convert.ToDouble(tbxBreite.Text), Convert.ToDouble(tbxHoehe.Text));
                // Eigenschaften mit Werten aus Textboxen füllen 
             

                // Fläche und Umfang in den entsprechenden Textboxen ausgeben 
                tbxFlaeche.Text= r.Flaeche.ToString();
                tbxUmfang.Text = r.Umfang.ToString();

           }
     //wenn eine Exception auftritt, dann...      
           catch (Exception ex)

           {

               MessageBox.Show(ex.Message, "Fehler");

            }
        }
    }
}
