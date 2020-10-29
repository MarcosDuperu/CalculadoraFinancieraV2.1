using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraVisual
{
    public partial class Form1 : Form
    {
        /*atributos*/
        bool volver = false;
        int indexDesSimple;
        int indexInSimple;
        int indexInCompuesto;
        double valor1, valor2, valor3, resultado;
        int valorN;
        string val1, val2, val3, valN;



        /*Constructor*/
        public Form1()
        {
            InitializeComponent();
        }



        /*Caja de Ingreso*/
        private void ingresVal1_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 40 && e.KeyChar <= 57)
            {
                e.Handled = false;
                val1=e.ToString();
            }
            else
            {
                e.Handled = true;
            }
        }
        private void ingresVal2_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 40 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void ingresVal3_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 40 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        /*muestra formula*/
        private void muestraInFSimple_Click(object sender, EventArgs e)
        {

        }
        private void muestraResultado_Click(object sender, EventArgs e)
        {

        }

        /*ComboBox´s*/
        private void comBoxInSimple_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBoxInCompuesto.Enabled = false;
            comBoxDesSimple.Enabled = false;

            indexInSimple = comBoxInSimple.SelectedIndex;

            switch (indexInSimple)
            {
                case 0:
                    vacio();
                    muestraFormula.Text = "VF = VA * (1+ n* i )";
                    encendidos();
                    break;
                case 1:
                    vacio();
                    muestraFormula.Text = "VF = VA + I";
                    encendidos();
                    ingresVal3.Enabled = false;
                    ingresVal3.BackColor = Color.Gray;
                    break;
                case 2:
                    vacio();
                    muestraFormula.Text = "VF = VA * (1+i*n)";
                    encendidos();

                    break;
                case 3:
                    vacio();
                    muestraFormula.Text = "VA = VF / (1+ n* i )";
                    encendidos();
                    break;
                case 4:
                    vacio();
                    muestraFormula.Text = "I = VF-VA";
                    encendidos();
                    ingresVal3.Enabled = false;
                    ingresVal3.BackColor = Color.Gray;
                    break;
                case 5:
                    vacio();
                    muestraFormula.Text = "I = VA * n * i";
                    encendidos();
                    break;
                case 6:
                    vacio();
                    muestraFormula.Text = "i = I / (VA*n)";
                    encendidos();
                    break;
                case 7:
                    vacio();
                    muestraFormula.Text = "i = (( VF / VA) -1 ) / n";
                    encendidos();
                    break;
                case 8:
                    vacio();
                    muestraFormula.Text = "n = I / ( VA * i )";
                    encendidos();
                    break;
                case 9:
                    vacio();
                    muestraFormula.Text = "n = (( VF / VA ) – 1 ) / i";
                    encendidos();
                    break;
                default:
                    break;
            }
        }

        private void comBoxInCompuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBoxInSimple.Enabled = false;
            comBoxDesSimple.Enabled = false;

            indexInCompuesto = comBoxInCompuesto.SelectedIndex;

            switch (indexInCompuesto)
            {

                case 0:
                    vacio();
                    muestraFormula.Text = "VF = VA * ((1 + i)^n)";
                    encendidos();

                    break;
                case 1:
                    vacio();
                    muestraFormula.Text = "I = VA * ((1+i)n −1)";
                    encendidos();
                    break;
                case 2:
                    vacio();
                    muestraFormula.Text = "VA = VF / ( 1 + i)^n";
                    encendidos();

                    break;
                case 3:
                    vacio();
                    muestraFormula.Text = "VA = VF / ( 1 + i)^-n";
                    encendidos();
                    break;
                case 4:
                    vacio();
                    muestraFormula.Text = "i = n^√ ( VF / VA) - 1";
                    encendidos();
                    break;
                case 5:
                    vacio();
                    muestraFormula.Text = "n = LOG( VF / VA) / LOG(1+i)";
                    encendidos();
                    break;
                default:
                    break;
            }
        }
        private void comBoxDesSimple_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBoxInSimple.Enabled = false;
            comBoxInCompuesto.Enabled = false;
            indexDesSimple = comBoxDesSimple.SelectedIndex;
            switch (indexDesSimple)
            {
                case 0:
                    vacio();

                    muestraFormula.Text = "DR = VF – VA";
                    encendidos();
                    ingresVal3.Enabled = false;
                    ingresVal3.BackColor = Color.Gray;
                    break;
                case 1:
                    vacio();
                    muestraFormula.Text = "DR = VF * n * i";
                    encendidos();
                    break;
                default:
                    break;
            }
        }

        /*metodos utilizados*/
        public void encendidos()
        {
            ingresVal1.Enabled = true;
            ingresVal2.Enabled = true;
            ingresVal3.Enabled = true;
            ingresVal1.BackColor = Color.FloralWhite;
            ingresVal2.BackColor = Color.FloralWhite;
            ingresVal3.BackColor = Color.FloralWhite;
        }
        public void apagado()//Ingresos apagados
        {
            ingresVal1.Enabled = false;
            ingresVal2.Enabled = false;
            ingresVal3.Enabled = false;
            ingresVal1.BackColor = Color.Gray;
            ingresVal2.BackColor = Color.Gray;
            ingresVal3.BackColor = Color.Gray;

        }
        public void vacio()//deja los ingresos vacios
        {
            ingresVal1.Text = "";
            ingresVal2.Text = "";
            ingresVal3.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            apagado();
        }
        /*Botones*/
        private void btSalir_Click(object sender, EventArgs e)
        {
            volver = true;
            muestraFormula.Text = null;
            comBoxDesSimple.Text = null;
            comBoxInCompuesto.Text = null;
            comBoxInSimple.Text = null;
            muestraResultado.Text = "";
            //cada vez q apriete volver se apague todo
            apagado();
            vacio();
            if (volver)
            {
                comBoxInSimple.Enabled = true;
                comBoxInCompuesto.Enabled = true;
                comBoxDesSimple.Enabled = true;
            }
        }

        private void btSeleccionar_Click(object sender, EventArgs e)
        {
             bool seguir = false;
            if (ingresVal3.Enabled == true)
            {
                if (ingresVal1.Text == "" || ingresVal2.Text == "" || ingresVal3.Text == "") MessageBox.Show("No ingreso ningun numero");
                else seguir = true;
                
            } else
            {
                if (ingresVal1.Text == "" || ingresVal2.Text == "") MessageBox.Show("No ingreso ningun numero");
                else seguir = true;
            }
            if (seguir)
            {
                indexDesSimple = comBoxDesSimple.SelectedIndex;
                indexInSimple = comBoxInSimple.SelectedIndex;
                indexInCompuesto = comBoxInCompuesto.SelectedIndex;

                switch (indexInSimple)
                {
                    case 0://Listo VF = VA * (1+ n* i )
                        val1 = ingresVal1.Text;
                        valor1 = Convert.ToDouble(val1);
                        valN = ingresVal2.Text;
                        try
                        {
                            valorN = Convert.ToInt32(valN);
                        }
                        catch (System.FormatException error)
                        {
                            MessageBox.Show("No es un valor entero");
                        }
                        val3 = ingresVal3.Text;
                        valor3 = Convert.ToDouble(val3);

                        resultado = valor1 * (1 + valorN * valor3);
                        muestraResultado.Text = resultado.ToString();
                        break;
                    case 1:// listo VF = VA + I
                        val1 = ingresVal1.Text;
                        valor1 = Convert.ToDouble(val1);
                        val2 = ingresVal2.Text;
                        valor2 = Convert.ToDouble(val2);

                        resultado = valor1 + valor2;
                        muestraResultado.Text = resultado.ToString();
                        break;
                    case 2://listo VF = VA * (1+i*n)
                        val1 = ingresVal1.Text;
                        valor1 = Convert.ToDouble(val1);
                        valN = ingresVal3.Text;
                        try
                        {
                            valorN = Convert.ToInt32(valN);
                        }
                        catch (System.FormatException error)
                        {
                            MessageBox.Show("No es un valor entero");
                        }
                        val2 = ingresVal2.Text;
                        valor2 = Convert.ToDouble(val2);

                        resultado = valor1 * (1 + valor2 * valorN);
                        muestraResultado.Text = resultado.ToString();
                        break;
                    case 3://listo VA = VF / (1+ n* i )
                        val1 = ingresVal1.Text;
                        valor1 = Convert.ToDouble(val1);
                        valN = ingresVal2.Text;
                        try
                        {
                            valorN = Convert.ToInt32(valN);
                        }
                        catch (System.FormatException error)
                        {
                            MessageBox.Show("No es un valor entero");
                        }
                        val3 = ingresVal3.Text;
                        valor3 = Convert.ToDouble(val3);

                        resultado = valor1 / (1 + valorN * valor3);
                        muestraResultado.Text = resultado.ToString();
                        break;
                    case 4:// listo I = VF-VA
                        val1 = ingresVal1.Text;
                        valor1 = Convert.ToDouble(val1);
                        val2 = ingresVal2.Text;
                        valor2 = Convert.ToDouble(val2);

                        resultado = valor1 - valor2;
                        muestraResultado.Text = resultado.ToString();
                        break;
                    case 5://listo I = VA * n * i
                        val1 = ingresVal1.Text;
                        valor1 = Convert.ToDouble(val1);
                        valN = ingresVal2.Text;
                        try
                        {
                            valorN = Convert.ToInt32(valN);
                        }
                        catch (System.FormatException error)
                        {
                            MessageBox.Show("No es un valor entero");
                        }
                        val3 = ingresVal3.Text;
                        valor3 = Convert.ToDouble(val3);

                        resultado = valor1 * valorN * valor3;
                        muestraResultado.Text = resultado.ToString();

                        break;
                    case 6://listo i = I / (VA*n)
                        val1 = ingresVal1.Text;
                        valor1 = Convert.ToDouble(val1);
                        valN = ingresVal3.Text;
                        try
                        {
                            valorN = Convert.ToInt32(valN);
                        }
                        catch (System.FormatException error)
                        {
                            MessageBox.Show("No es un valor entero");
                        }
                        val2 = ingresVal2.Text;
                        valor2 = Convert.ToDouble(val2);

                        resultado = valor1 / (valor2 * valorN);
                        muestraResultado.Text = resultado.ToString();
                        break;
                    case 7://listo i = (( VF / VA) -1 ) / n
                        val1 = ingresVal1.Text;
                        valor1 = Convert.ToDouble(val1);
                        valN = ingresVal3.Text;
                        try
                        {
                            valorN = Convert.ToInt32(valN);
                        }
                        catch (System.FormatException error)
                        {
                            MessageBox.Show("No es un valor entero");
                        }
                        val2 = ingresVal2.Text;
                        valor2 = Convert.ToDouble(val2);
                        resultado = ((valor1 / valor2) - 1) / valorN;
                        muestraResultado.Text = resultado.ToString();

                        break;
                    case 8://listo n = I / ( VA * i )
                        val1 = ingresVal1.Text;
                        valor1 = Convert.ToDouble(val1);
                        val2 = ingresVal2.Text;
                        valor2 = Convert.ToDouble(val2);
                        val3 = ingresVal3.Text;
                        valor3 = Convert.ToDouble(val3);

                        resultado = valor1 / (valor2 * valor3);
                        muestraResultado.Text = resultado.ToString();

                        break;
                    case 9://listo n = (( VF / VA ) – 1 ) / i
                        val1 = ingresVal1.Text;
                        valor1 = Convert.ToDouble(val1);
                        val2 = ingresVal2.Text;
                        valor2 = Convert.ToDouble(val2);
                        val3 = ingresVal3.Text;
                        valor3 = Convert.ToDouble(val3);
                        resultado = ((valor1 / valor2) - 1) / valor3;
                        muestraResultado.Text = resultado.ToString();

                        break;
                    default:
                        break;

                }
                switch (indexInCompuesto)
                {

                    case 0://listo VF = VA * ((1 + i)^n)
                        val1 = ingresVal1.Text;
                        valor1 = Convert.ToDouble(val1);
                        val2 = ingresVal2.Text;
                        valor2 = Convert.ToDouble(val2);
                        valN = ingresVal3.Text;
                        try
                        {
                            valorN = Convert.ToInt32(valN);
                        }
                        catch (System.FormatException error)
                        {
                            MessageBox.Show("No es un valor entero");
                        }
                        resultado = valor1 * (Math.Pow((1 + valor2), valorN));
                        muestraResultado.Text = resultado.ToString();
                        break;
                    case 1://listo I = VA * (((1+i)^n) −1)
                        val1 = ingresVal1.Text;
                        valor1 = Convert.ToDouble(val1);
                        val2 = ingresVal2.Text;
                        valor2 = Convert.ToDouble(val2);
                        valN = ingresVal3.Text;
                        try
                        {
                            valorN = Convert.ToInt32(valN);
                        }
                        catch (System.FormatException error)
                        {
                            MessageBox.Show("No es un valor entero");
                        }
                        resultado = valor1 * ((Math.Pow((1 + valor2), valorN)) - 1);
                        muestraResultado.Text = resultado.ToString();
                        break;
                    case 2://listo VA = VF / ( 1 + i)^n
                        val1 = ingresVal1.Text;
                        valor1 = Convert.ToDouble(val1);
                        val2 = ingresVal2.Text;
                        valor2 = Convert.ToDouble(val2);
                        valN = ingresVal3.Text;
                        try
                        {
                            valorN = Convert.ToInt32(valN);
                        }
                        catch (System.FormatException error)
                        {
                            MessageBox.Show("No es un valor entero");
                        }
                        resultado = valor1 / (Math.Pow((1 + valor2), valorN));
                        muestraResultado.Text = resultado.ToString();

                        break;
                    case 3://listo VA = VF / ( 1 + i)^-n
                        val1 = ingresVal1.Text;
                        valor1 = Convert.ToDouble(val1);
                        val2 = ingresVal2.Text;
                        valor2 = Convert.ToDouble(val2);
                        valN = ingresVal3.Text;
                        try
                        {
                            valorN = Convert.ToInt32(valN);
                        }
                        catch (System.FormatException error)
                        {
                            MessageBox.Show("No es un valor entero");
                        }
                        resultado = valor1 / (Math.Pow((1 + valor2), (-1 * valorN)));
                        muestraResultado.Text = resultado.ToString();
                        break;
                    case 4://listo i = n^√ ( VF / VA) - 1
                        valN = ingresVal1.Text;
                        try
                        {
                            valorN = Convert.ToInt32(valN);
                        }
                        catch (System.FormatException error)
                        {
                            MessageBox.Show("No es un valor entero");
                        }
                        val2 = ingresVal2.Text;
                        valor2 = Convert.ToDouble(val2);
                        val3 = ingresVal3.Text;
                        valor3 = Convert.ToDouble(val3);
                        resultado = (Math.Pow((valor2 / valor3), 1 / valorN)) - 1;
                        muestraResultado.Text = resultado.ToString();

                        break;
                    case 5://listo n = LOG( VF / VA) / LOG(1+i)
                        val1 = ingresVal1.Text;
                        valor1 = Convert.ToDouble(val1);
                        val2 = ingresVal2.Text;
                        valor2 = Convert.ToDouble(val2);
                        val3 = ingresVal3.Text;
                        valor3 = Convert.ToDouble(val3);
                        resultado = (Math.Log10((valor1 / valor2))) / (Math.Log10((1 + valor3)));
                        int resultadoN = Convert.ToInt32(resultado);
                        muestraResultado.Text = resultadoN.ToString();
                        break;
                    default:
                        break;
                }
                switch (indexDesSimple)
                {
                    case 0://listo DR = VF – VA
                        val1 = ingresVal1.Text;
                        valor1 = Convert.ToDouble(val1);
                        val2 = ingresVal2.Text;
                        valor2 = Convert.ToDouble(val2);

                        resultado = valor1 - valor2;
                        muestraResultado.Text = resultado.ToString();
                        break;
                    case 1://listo DR = VF * n * i
                        val1 = ingresVal1.Text;
                        valor1 = Convert.ToDouble(val1);
                        valN = ingresVal2.Text;
                        try
                        {
                            valorN = Convert.ToInt32(valN);
                        } catch (System.FormatException error)
                        {
                            MessageBox.Show("No es un valor entero");
                        }
                        val3 = ingresVal3.Text;
                        valor3 = Convert.ToDouble(val3);

                        resultado = valor1 * valorN * valor3;
                        muestraResultado.Text = resultado.ToString();
                        break;
                    default:
                        break;
                }
            }
            
    }
    }
}

