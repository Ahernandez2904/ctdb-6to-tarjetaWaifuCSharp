using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz4
{
    public partial class Form1 : Form
    {
        //Variables que se van a usar
        public static int edad = 0; public static int aux = 0;
        public static int a = 0; public static int m = 0; public static int d = 0;
        public static int a1 = 0; public static int m1 = 0; public static int d1 = 0;
        public static int a2 = 0; public static int m2 = 0; public static int d2 = 0;
        public static int c1 = 0; public static int c2 = 0;

        public static string nombre = ""; public static string ap = "";
        public static string nt = ""; public static string cs = ""; public static string id = "";

        public Form1(){ InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) {
            //aux = 0;
            a1 = DateTime.Today.Year; m1 = DateTime.Today.Month; d1 = DateTime.Today.Day;//Fecha del sistema
            //if (m1 > 12) { textBox12.Text = ""; MessageBox.Show("Eeeeeh? No hay más de 12 meses en el año -.-\nVoy a dejar ese espacio en blanco así que rellenalo uwu~"); }
            //if (d1 > 31) { textBox13.Text = ""; MessageBox.Show("Eeeeeh? No hay más de 31 días por mes -.-\nVoy a dejar ese espacio en blanco así que rellenalo uwu~"); }
            if (textBox10.Text == "" || textBox9.Text == "" ||
                textBox8.Text == "" || textBox7.Text == "" || textBox6.Text == "" || textBox5.Text == "" ||
                textBox4.Text == "" || textBox3.Text == "" || textBox2.Text == "" || textBox1.Text == "" /*|| 
                textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == ""*/)//Si hay un campo vacío, no recoger datos
            { /*aux = 1;*/  MessageBox.Show("Sempai... \n¿Estas dudando si esto es un malware?\n Ehmm... ¡¡¡P-Por supuesto que no!!! \n\nTe compraré regalos :D"); }
            else {
                if (Convert.ToInt64(textBox9.Text) < 100000000000) { textBox9.Text = ""; MessageBox.Show("Eeeeemmmmm... Creo que las tarjetas\ntienen más de 12 digitos... uwu~"); }
                if (Convert.ToInt32(textBox8.Text) < 100) { textBox8.Text = ""; MessageBox.Show("Si mal no recuerdo... \nEl código de seguridad es de tres digitos... uwu~"); }
                if (Convert.ToInt32(textBox2.Text) < 100000000) { textBox2.Text = ""; MessageBox.Show("En Costa Rica las cédulas \ntienen nueve digitos :D"); }
                if (Convert.ToInt32(textBox6.Text) > 12) { textBox6.Text = ""; MessageBox.Show("Eeeeeh? No hay más de 12 meses en el año -.-\nVoy a dejar ese espacio en blanco así que rellenalo uwu~"); }
                if (Convert.ToInt32(textBox4.Text) > 12) { textBox4.Text = ""; MessageBox.Show("Eeeeeh? No hay más de 12 meses en el año -.-\nVoy a dejar ese espacio en blanco así que rellenalo uwu~"); }
                if (Convert.ToInt32(textBox3.Text) > 31) { textBox3.Text = ""; MessageBox.Show("Eeeeeh? No hay más de 31 días por mes -.-\nVoy a dejar ese espacio en blanco así que rellenalo uwu~"); }
                if (Convert.ToInt32(textBox7.Text) < a1 - 2000) { textBox6.Text = ""; textBox7.Text = ""; MessageBox.Show("ONIIIII-CHAAAAAAAAAN!!!!\nLa tarjeta ya venció D:"); }
                if (Convert.ToInt32(textBox7.Text) == a1 - 2000 && Convert.ToInt32(textBox6.Text) < m1) { textBox6.Text = ""; textBox7.Text = ""; MessageBox.Show("ONIIIII-CHAAAAAAAAAN!!!!\nLa tarjeta ya venció D:"); }
                if (textBox10.Text == "" || textBox9.Text == "" ||
                textBox8.Text == "" || textBox7.Text == "" || textBox6.Text == "" || textBox5.Text == "" ||
                textBox4.Text == "" || textBox3.Text == "" || textBox2.Text == "" || textBox1.Text == "") { /*Regañado*/ } else {
                //recoger datos
                    d = Convert.ToInt32(textBox3.Text); a = Convert.ToInt32(textBox5.Text); m = Convert.ToInt32(textBox4.Text);
                    //d1 = Convert.ToInt32(textBox13.Text); a1 = Convert.ToInt32(textBox11.Text); m1 = Convert.ToInt32(textBox12.Text);
                    c1 = Convert.ToInt32(textBox6.Text); c2 = Convert.ToInt32(textBox7.Text);
                    nombre = textBox10.Text; ap = textBox1.Text; id = textBox2.Text;
                    cs = textBox8.Text; nt = textBox9.Text;
                    a2 = a1 - a; m2 = m1 - m; d2 = d1 - d; //Calcular edad
                    do { if (d2 < 0) { d2 = d2 + 30; m2 = m2 - 1; } if (d2 > 30) { d2 = d2 - 30; m2 = m2 - 1; } } while (d2 < 0);//evita que la edad en días sea mayor o menor que lo posible
                    do { if (m2 < 0) { m2 = m2 + 12; a2 = a2 - 1; } if (m2 > 12) { m2 = m2 - 12; a2 = a2 - 1; } } while (m2 < 0);//evita que la edad en meses sea mayor o menor que lo posible
                    edad = a2; if (a2 < 0) { MessageBox.Show("Eeeeeh? Es imposible viajar en el tiempo...\nAcaso eres un viajero del tiempo :O?"); /*Edad negativa, paradoja? Tengo yo el derecho de evitar que alguien que viajo en el tiempo, pueda usar tarjeta de crédito?*/ }
                    MessageBox.Show("Gr-Gracias... ♥\nComprando regalos~\n\nMe pregunto que le gustará a\nlas personas de " + edad + " años~");
                    MessageBox.Show("Datos guardados: \nNombre: " + nombre + "\nApellidos: " + ap + "\nNacimiento: " +
                        d + "/" + m + "/" + a + "\nN° de Tarjeta: " + nt + "\nCódigo de Seguridad: " + cs +
                        "\nCódigo de Caducidad: " + c1 + "/" + c2 + "\nNumero de cédula: " + id + "\nFecha de hoy: " +
                        d1 + "/" + m1 + "/" + a1 + "\nEdad Aproximada: " + d2 + "/" + m2 + "/" + a2); this.Close();
                    //Mensaje con los datos guardados y cerrar
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e) { /*Dia*/ }
        private void textBox4_TextChanged(object sender, EventArgs e) { /*Mes*/ }
        private void textBox5_TextChanged(object sender, EventArgs e) { /*Año*/ }
        private void textBox10_TextChanged(object sender, EventArgs e){/*Nomb*/}
        private void textBox1_TextChanged(object sender, EventArgs e) { /*Ap*/}
        private void textBox2_TextChanged(object sender, EventArgs e) { /*id*/}
        private void textBox6_TextChanged(object sender, EventArgs e) { /*Caducidad mes*/}
        private void textBox7_TextChanged(object sender, EventArgs e) { /*Caducidad año*/}
        private void textBox8_TextChanged(object sender, EventArgs e) { /*Codigo de seguridad*/}
        private void textBox9_TextChanged(object sender, EventArgs e) { /*N Tarjeta*/}

        //Lineas de codigo para evitar escribir caracteres especiales (Numeros, letras, puntuacion, simbolos, espacios) dependiendo de lo que se necesite
        private void textBox10_KeyPress(object sender, KeyPressEventArgs e){ if (Char.IsNumber(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar)) { e.Handled = true; } }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) { if (Char.IsNumber(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar)) { e.Handled = true; } }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) { if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsSymbol(e.KeyChar)) { e.Handled = true; } }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e) { if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsSymbol(e.KeyChar)) { e.Handled = true; } }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e) { if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsSymbol(e.KeyChar)) { e.Handled = true; } }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e) { if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsSymbol(e.KeyChar)) { e.Handled = true; } }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e) { if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsSymbol(e.KeyChar)) { e.Handled = true; } }
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e) { if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsSymbol(e.KeyChar)) { e.Handled = true; } }
        private void textBox8_KeyPress(object sender, KeyPressEventArgs e) { if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsSymbol(e.KeyChar)) { e.Handled = true; } }
        private void textBox9_KeyPress(object sender, KeyPressEventArgs e) { if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsSymbol(e.KeyChar)) { e.Handled = true; } }


        /*private void textBox13_TextChanged(object sender, EventArgs e) { }//d
        private void textBox12_TextChanged(object sender, EventArgs e) { }//m
        private void textBox11_TextChanged(object sender, EventArgs e) { }//a

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e) { if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsSymbol(e.KeyChar)) { e.Handled = true; } }
        private void textBox12_KeyPress(object sender, KeyPressEventArgs e) { if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsSymbol(e.KeyChar)) { e.Handled = true; } }
        private void textBox13_KeyPress(object sender, KeyPressEventArgs e) { if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsSymbol(e.KeyChar)) { e.Handled = true; } }
        //private void textBox1_KeyPress(object sender, KeyPressEventArgs e) { if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsSymbol(e.KeyChar)) { e.Handled = true; } if (e.KeyChar == ',' || e.KeyChar == '.') { e.Handled = false; } }
    */
    }
}
