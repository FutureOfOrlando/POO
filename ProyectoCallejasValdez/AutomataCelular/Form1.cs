using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace AutomataCelular
{
    public partial class Main : Form
    {
        //Variables respectivas de las dimensiones
        private int Longitud = 40;
        private int LongitudPixel = 10;
        int[,] celulas = new int[40,40]; 

        public Main()
        {
            InitializeComponent();

            //Matriz por defecto
            celulas = new int[Longitud, Longitud];
            try
            {
                List<Save> saves = new List<Save>();
                saves = SaveBD.ReadFromTXT(@".\MatrizPorDefecto.txt");
                int f = 0, l = 0;
                foreach (Save p in saves)
                {
                    celulas[l, f] = p.celulasBd;
                    f++;
                    if (f == 40)
                    {
                        l++;
                        f = 0;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No se encontro el archivo: MatrizPorDefecto.txt", "Error");
                Close();
            }
            
            PintarMatriz();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PintarMatriz();
        }
        /*-------------------------------Fin del código para matriz por defecto-------------------------*/
        private void PintarMatriz()
        {   /*Método que pinta la matriz en el bitmap*/
            Bitmap bmp = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            for (int x=0;x<Longitud;x++)
            {
                for (int y=0;y<Longitud;y++)
                {
                    if (celulas[x, y] == 0)
                        PintarPixel(bmp, x, y, Color.Black);
                    else
                        PintarPixel(bmp, x, y, Color.White);
                }
            }
            pictureBox1.Image = bmp;
        }
        private void PintarPixel(Bitmap bmp, int x, int y,Color color)
        {
            for ( int i=0;i<LongitudPixel; i++)
                for(int j=0;j<LongitudPixel; j++)
                bmp.SetPixel(i+ (x*LongitudPixel),j+(y*LongitudPixel),color);
            
        }
        /*-----------------------------------Fin del código para pintar-------------------------------------*/
        
        private void JuegoDeLaVida()
        {   /*Código del juego tanto como el funcionamiento como las reglas*/
            int[,] celulasTemp = new int[Longitud, Longitud];
            for (int x = 0; x < Longitud; x++)
            {
                for (int y = 0; y < Longitud; y++)
                {
                    if (celulas[x, y] == 0)
                        celulasTemp[x, y] = ReglaJuegoVida(x,y,false);
                    else
                        celulasTemp[x, y] = ReglaJuegoVida(x, y, true);
                }
            }

            celulas = celulasTemp;

        }

        private int ReglaJuegoVida(int x, int y, bool EsViva)
        {
            int VecinasVivas = 0;
            /*1 2 3
              4 # 5
              6 7 8*/
            //vecina 1
            if (x > 0&&y>0)
            if (celulas[x - 1, y - 1] == 1)
                VecinasVivas++;
            //vecina 2
            if (y > 0)
                if (celulas[x, y - 1] == 1)
                    VecinasVivas++;
            //vecina 3
            if (x < Longitud - 1 && y > 0)
                if (celulas[x + 1, y - 1] == 1)
                    VecinasVivas++;
            //vecina 4
            if (x > 0)
                if (celulas[x - 1, y] == 1)
                    VecinasVivas++;
            //vecina 5
            if (x < Longitud - 1)
                if (celulas[x + 1, y] == 1)
                    VecinasVivas++;
            //vecina 6
            if (x > 0 && y < Longitud - 1)
                if (celulas[x - 1, y + 1] == 1)
                    VecinasVivas++;
            //vecina 7
            if (y < Longitud - 1)
                if (celulas[x, y + 1] == 1)
                    VecinasVivas++;
            //vecina 8
            if (x < Longitud - 1 && y < Longitud - 1)
                if (celulas[x + 1, y + 1] == 1)
                    VecinasVivas++;
            if (EsViva)
                return (VecinasVivas == 2 || VecinasVivas == 3) ? 1 : 0;
            else
                return VecinasVivas == 3 ? 1 : 0;

        }
        /*-------------------------------Fin de las reglas y el juego en sí----------------------------------*/
        private void button3_Click(object sender, EventArgs e)
        {
            /*Botón de matriz Random*/
            for (int i = 0; i < Longitud; i++)
                for (int j = 0; j < Longitud; j++)
                    celulas[i, j] = 0;
            Random r = new Random();
            for (int i = 0; i < Longitud; i++)
                for (int j = 0; j < Longitud; j++)
                    celulas[i, j] = r.Next(0,2);

            PintarMatriz();
            Generacion.Text = "1";
        }
        /*----------------------------------------*/
        private void button1_Click(object sender, EventArgs e)
        {   /*Botón de inicio*/
            timer1.Enabled = true;
            Pausar.Enabled = true;
            Iniciar.Enabled = false;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {   /*Botón de pausa*/
            timer1.Enabled = false;
            Pausar.Enabled = false;
            Iniciar.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            JuegoDeLaVida();
            PintarMatriz();
            //Generación 
            if (Generacion.Text == "?")
            {
                int G = 0;
                G++;
                Generacion.Text = G.ToString();
            }
            else 
            {
                int G = int.Parse(Generacion.Text);
                G++;
                Generacion.Text = G.ToString();
            }
            //Guardado de las partidas en tiempo real
            List<Save> saves2 = new List<Save>();
            if (Save1.Enabled == false)
            {
                for (int l = 0; l < 40; l++)
                {
                    for (int f = 0; f < 40; f++)
                    {
                        saves2.Add(new Save(celulas[l, f]));
                    }
                }
                SaveBD.WriteToTXT("MatrizSave1.txt", saves2);
            }
            else if (Save2.Enabled == false)
            {
                for (int l = 0; l < 40; l++)
                {
                    for (int f = 0; f < 40; f++)
                    {
                        saves2.Add(new Save(celulas[l, f]));
                    }
                }
                SaveBD.WriteToTXT("MatrizSave2.txt", saves2);
            }
            else { }
            
            /*-----------------------Fin del guardado------------------------*/
        }

        private void Main_MouseClick(object sender, MouseEventArgs e)
        {
            
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {   /*Código que indica la celula clickeada*/
            this.label2.Text = "Célula: " + String.Format("{0}, {1}", e.X/10 + 1, e.Y/10 + 1);
            if (celulas[e.X / 10, e.Y / 10] == 1)
                celulas[e.X / 10, e.Y / 10] = 0;
            else if (celulas[e.X / 10, e.Y / 10] == 0)
                celulas[e.X / 10, e.Y / 10] = 1;

            PintarMatriz();
        }
        /*------------------------------------------------------------------------------------------------*/
        /*parte de código que guarda las matrices y las lee*/

        class Save
        {
            public Save(int celulasBd)
            {
                this.celulasBd = celulasBd;
            }
            public int celulasBd { get; set; }
        }

        class SaveBD
        {

            public static void WriteToTXT(string path, List<Save> saves2)
            {
                
                StreamWriter txtOut = new StreamWriter(
                                      new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write));
                foreach (Save p in saves2)
                {
                    txtOut.Write("{0},", p.celulasBd);
                }
                txtOut.Close();
            }

            public static List<Save> ReadFromTXT(string path)
            {
                List<Save> saves = new List<Save>();
                StreamReader txtIn = new StreamReader(
                                     new FileStream(path, FileMode.Open, FileAccess.Read));
                while (txtIn.Peek() != -1)
                {
                    string Line = txtIn.ReadLine();
                    string[] columns = Line.Split(',');
                    
                    for (int l = 0; l < 1600; l++)
                    {
                        Save p = new Save(int.Parse(columns[l]));
                        saves.Add(p);
                    }
                }
                txtIn.Close();
                return saves;
            }
        }
        /*-------------------------------------Fin de guardar y leer---------------------------------------*/
        private void Limpiar_Click(object sender, EventArgs e)
        {   /*Limpiar el picture*/
            for (int x = 0; x < Longitud; x++)
            {
                for (int y = 0; y < Longitud; y++)
                {
                    celulas[x, y] = 0;
                }
                
            }
            PintarMatriz();
            Generacion.Text = "0";
            timer1.Enabled = false;
            Iniciar.Enabled = true;
            Pausar.Enabled = false;
        }

        private void Save1_Click(object sender, EventArgs e)
        {   /*Cambio al puerto de guardado uno y carga de la partida del slot 1*/
            Save1.Enabled = false;
            Save2.Enabled = true;
            Generacion.Text = "?";
            //Matriz Slot 1
            celulas = new int[Longitud, Longitud];
            List<Save> saves2 = new List<Save>();
            try
            {
                saves2 = SaveBD.ReadFromTXT(@".\MatrizSave1.txt");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No se encontro el archivo: MatrizPorSave2.txt", "Error"); 
                Close();
            }
                int f = 0, l = 0;
            foreach (Save p in saves2)
            {
                celulas[l, f] = p.celulasBd;
                f++;
                if (f == 40)
                {
                    l++;
                    f = 0;
                }
                
            }
            
            PintarMatriz();

        }

        private void Save2_Click(object sender, EventArgs e)
        {   /*Cambio al puerto de guardado dos y carga de la partida del slot 2*/
            Save2.Enabled = false;
            Save1.Enabled = true;
            Generacion.Text = "?";
            //Matriz Slot 2
            celulas = new int[Longitud, Longitud];
            List<Save> saves2 = new List<Save>();
            try
            {
                saves2 = SaveBD.ReadFromTXT(@".\MatrizSave2.txt");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No se encontro el archivo: MatrizSave2.txt", "Error"); 
                Close();
            }
            int f = 0, l = 0;
            foreach (Save p in saves2)
            {
                celulas[l, f] = p.celulasBd;
                f++;
                if (f == 40)
                {
                    l++;
                    f = 0;
                }
            }
            PintarMatriz();

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
