namespace get.set_Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                tbxFlaeche.Text = r.Flaeche.ToString();
                tbxUmfang.Text = r.Umfang.ToString();
                // Diagonale wird in den entsprechenden Textboxen ausgeben 
                tbxDiagonal.Text = r.Diagonale().ToString();
            }
            //wenn eine Exception auftritt, dann...      
            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Fehler");

            }
        }

       

        private void btnZoom_Click(object sender, EventArgs e)
        {
            try
            {
                Rechteck r = new Rechteck(
                    Convert.ToDouble(tbxHoehe.Text),
                    Convert.ToDouble(tbxBreite.Text)
                );

                r.zoomen(2);

                // Neue Höhe und Breite anzeigen
                tbxHoehe.Text = r.Hoehe.ToString();
                tbxBreite.Text = r.Breite.ToString();

                // Fläche und Umfang aktualisieren
                tbxFlaeche.Text = r.Flaeche.ToString();
                tbxUmfang.Text = r.Umfang.ToString();
                tbxDiagonal.Text = r.Diagonale().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Das Rechteck wird erstellt gedreht und die neuen Werte werden angezeigt wenn man auf den button klickt
        private void btnDrehen_Click(object sender, EventArgs e)
        {
            try
            {
                Rechteck r = new Rechteck(
                    Convert.ToDouble(tbxHoehe.Text),
                    Convert.ToDouble(tbxBreite.Text)
                );

                r.Rechtsumdrehung();

                // Neue Werte anzeigen
                tbxHoehe.Text = r.Hoehe.ToString();
                tbxBreite.Text = r.Breite.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

       
    }
}
