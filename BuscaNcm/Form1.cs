using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keys = OpenQA.Selenium.Keys;

namespace BuscaNcm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            #region Estados


            // box dos estados 

            boxEstado.Items.Add("AC");
            boxEstado.Items.Add("AL");
            boxEstado.Items.Add("AP");
            boxEstado.Items.Add("AM");
            boxEstado.Items.Add("BA");
            boxEstado.Items.Add("CE");
            boxEstado.Items.Add("DF");
            boxEstado.Items.Add("ES");
            boxEstado.Items.Add("GO");
            boxEstado.Items.Add("MA");
            boxEstado.Items.Add("MT");
            boxEstado.Items.Add("MS");
            boxEstado.Items.Add("MG");
            boxEstado.Items.Add("PA");
            boxEstado.Items.Add("PB");
            boxEstado.Items.Add("PR");
            boxEstado.Items.Add("PE");
            boxEstado.Items.Add("PI");
            boxEstado.Items.Add("RJ");
            boxEstado.Items.Add("RN");
            boxEstado.Items.Add("RS");
            boxEstado.Items.Add("RO");
            boxEstado.Items.Add("RR");
            boxEstado.Items.Add("SC");
            boxEstado.Items.Add("SP");
            boxEstado.Items.Add("SE");
            boxEstado.Items.Add("TO");
            // Começar pelo primeiro estado 
            boxEstado.SelectedIndex = 0;
            #endregion

    
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            MaskedTextBox mask = new MaskedTextBox();



            int ncm;
            if (!int.TryParse(txtNcm.Text, out ncm) && ncm == null)
            {
                MessageBox.Show("somente numeros são aceitos no campo NCM");
                return;
            }
            int i;
            if (!int.TryParse(txtncm2.Text, out i) && i == null)
            {
                MessageBox.Show("somente numeros são aceitos para complementar ncm");
                return;
            }
            dataGridViewResultados.Rows.Clear();
            while (boxEstado.SelectedIndex <= 30 )
            {
               
                try
                {

                    //abri o browser com selenium _______________________________________________________________
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("--headless");
                    ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                    service.HideCommandPromptWindow = true;


                    //adicionar o service e option para não mostra o prompt e nem browser _____________________________________________________
                    ChromeDriver driver = new ChromeDriver(service,options);

                    driver.Navigate().GoToUrl("http://www.econeteditora.com.br/icms_st/index.php?form%5Buf%5D=" + boxEstado.Text + "&form%5Bncm%5D=" + txtNcm.Text + "&form%5Bcest%5D=" + txtCest1.Text + "&form%5Bpalavra%5D=&acao=Buscar");

                    var clicar = driver.FindElement(By.TagName("input"));
                    clicar.Click();
                    //LOGIM_______________________________________________________________________________
                    string login = "";
                    string senha = "";

                    var userInput = driver.FindElementByName("Log");
                    userInput.SendKeys(login);

                    var passwordInput = driver.FindElementByName("Sen");
                    passwordInput.SendKeys(senha + Keys.Enter);

                    driver.Navigate().GoToUrl("http://www.econeteditora.com.br/icms_st/index.php?form%5Buf%5D=" + boxEstado.Text + "&form%5Bncm%5D=" + txtNcm.Text + "&form%5Bcest%5D=" + txtCest1.Text + "&form%5Bpalavra%5D=&acao=Buscar");


                 


                    //A BUSCA  NCM ____________________________________________________________________________
                    if (i == 00 || i == null)
                    {
                        var Primerabusca = driver.FindElementByTagName("input");
                        Primerabusca.Click();
                    }
                    else if (i > 00 && i <= 90)
                    {
                        var segundabusca = driver.FindElementByXPath("/html/body/table[3]/tbody/tr[3]/td[3]/input[1]");
                        segundabusca.Click();

                    }
                    else if (i > 90 && i <= 9010)
                    {
                        var terceirabusca = driver.FindElementByXPath("/html/body/table[3]/tbody/tr[7]/td[3]/input[1]");
                        terceirabusca.Click();
                    }
                    else
                    {
                        var quartabusca = driver.FindElementByXPath("/html/body/table[3]/tbody/tr[8]/td[3]/input[1]");
                        quartabusca.Click();
                    }


                    #region PEGAR OS DADOS DA PAGINA ATUAL PELO XPATH tit= titulo

                    //PEGAR OS DADOS DA PAGINA ATUAL PELO XPATH tit= titulo _________________________________________________________

                    var tit = "";
                    try { tit = driver.FindElementByXPath("//*[@id=\"TabbedPanels1\"]/div/div[1]/table[3]/tbody/tr[1]/td[1]").Text; } catch { tit = "não existe"; }
                    //-----------
                    var mvaO = "";
                    try { mvaO = driver.FindElementByXPath("//*[@id=\"TabbedPanels1\"]/div/div[1]/table[3]/tbody/tr[2]/td[1]").Text; } catch { mvaO = "não existe"; }
                    //------------

                    var tit1 = "";
                    try { tit1 = driver.FindElementByXPath("//*[@id=\"TabbedPanels1\"]/div/div[1]/table[3]/tbody/tr[1]/td[2]").Text; } catch { tit1 = "não existe"; }
                    //--------
                    var mva4 = "";
                    try { mva4 = driver.FindElementByXPath("//*[@id=\"TabbedPanels1\"]/div/div[1]/table[3]/tbody/tr[2]/td[2]").Text; } catch { mva4 = "não existe"; }
                    //--------  
                    var tit2 = "";
                    try { tit2 = driver.FindElementByXPath("//*[@id=\"TabbedPanels1\"]/div/div[1]/table[3]/tbody/tr[1]/td[3]").Text; } catch { tit2 = "não existe"; }
                    //------------
                    var mva7 = "";
                    try { mva7 = driver.FindElementByXPath("//*[@id=\"TabbedPanels1\"]/div/div[1]/table[3]/tbody/tr[2]/td[3]").Text; } catch { mva7 = "não existe"; }
                    //----------  
                    var tit3 = "";
                    try { tit3 = driver.FindElementByXPath("//*[@id=\"TabbedPanels1\"]/div/div[1]/table[3]/tbody/tr[1]/td[4]").Text; } catch { tit3 = "não existe"; }
                    //--------
                    var mva12 = "";
                    try { mva12 = driver.FindElementByXPath("//*[@id=\"TabbedPanels1\"]/div/div[1]/table[3]/tbody/tr[2]/td[4]").Text; } catch { mva12 = "não existe"; }
                    //-------

                    var tit4 = "";
                    try { tit4 = driver.FindElementByXPath("//*[@id=\"TabbedPanels1\"]/div/div[1]/table[3]/tbody/tr[1]/td[5]").Text; } catch { tit4 = "não existe"; }

                    //-------    
                    var aliq = "";
                    try { aliq = driver.FindElementByXPath("//*[@id=\"TabbedPanels1\"]/div/div[1]/table[3]/tbody/tr[2]/td[5]").Text; } catch { aliq = "não existe"; }

                    //-----

                    var tit5 = "";
                    try { tit5 = driver.FindElementByXPath("//*[@id=\"TabbedPanels1\"]/div/div[1]/table[3]/tbody/tr[1]/td[6]").Text; } catch { tit5 = "não existe"; }
                    //----------
                    var fecp = "";
                    try { fecp = driver.FindElementByXPath("//*[@id=\"TabbedPanels1\"]/div/div[1]/table[3]/tbody/tr[2]/td[6]").Text; } catch { fecp = "não existe"; }


                    //CASO HOUVER UMA SEGUNDA LINHA ADICIONAR AQUI______________________________________________________________________ 

                    var T1 = "";
                    try { T1 = driver.FindElementByXPath("//*[@id=\"TabbedPanels1\"]/div/div[1]/table[3]/tbody/tr[3]/td[1]").Text; } catch { T1 = ""; }

                    var T2 = "";
                    try { T2 = driver.FindElementByXPath("//*[@id=\"TabbedPanels1\"]/div/div[1]/table[3]/tbody/tr[3]/td[2]").Text; } catch { T2 = ""; }

                    var T3 = "";
                    try { T3 = driver.FindElementByXPath("//*[@id=\"TabbedPanels1\"]/div/div[1]/table[3]/tbody/tr[3]/td[3]").Text; } catch { T3 = ""; }

                    var T4 = "";
                    try { T4 = driver.FindElementByXPath("//*[@id=\"TabbedPanels1\"]/div/div[1]/table[3]/tbody/tr[3]/td[4]").Text; } catch { T4 = ""; }

                    var T5 = "";
                    try { T5 = driver.FindElementByXPath("//*[@id=\"TabbedPanels1\"]/div/div[1]/table[3]/tbody/tr[3]/td[5]").Text; } catch { T5 = ""; }

                    var T6 = "";
                    try { T6 = driver.FindElementByXPath("//*[@id=\"TabbedPanels1\"]/div/div[1]/table[3]/tbody/tr[3]/td[6]").Text; } catch { T6 = ""; }
                    // 3 LINHA TABELA SE EXISTIR ___________________________________________________________________________

                    var C1 = "";
                    try { C1 = driver.FindElementByXPath("//*[@id=\"TabbedPanels1\"]/div/div[1]/table[3]/tbody/tr[4]/td[1]").Text; } catch { C1 = ""; }

                    var C2 = "";
                    try { C2 = driver.FindElementByXPath("//*[@id=\"TabbedPanels1\"]/div/div[1]/table[3]/tbody/tr[4]/td[2]").Text; } catch { C2 = ""; }

                    var C3 = "";
                    try { C3 = driver.FindElementByXPath("//*[@id=\"TabbedPanels1\"]/div/div[1]/table[3]/tbody/tr[4]/td[3]").Text; } catch { C3 = ""; }

                    var C4 = "";
                    try { C4 = driver.FindElementByXPath("//*[@id=\"TabbedPanels1\"]/div/div[1]/table[3]/tbody/tr[4]/td[4]").Text; } catch { C4 = ""; }

                    var C5 = "";
                    try { C5 = driver.FindElementByXPath("//*[@id=\"TabbedPanels1\"]/div/div[1]/table[3]/tbody/tr[4]/td[5]").Text; } catch { C5 = ""; }

                    var C6 = "";
                    try { C6 = driver.FindElementByXPath("//*[@id=\"TabbedPanels1\"]/div/div[1]/table[3]/tbody/tr[4]/td[6]").Text; } catch { C6 = ""; }


                    #endregion


                    //Limpar e Adicionar valores na tabela__________________________________________________________________________________________________
                    //dataGridViewResultados.Rows.Clear();

                    dataGridViewResultados.Rows.Add(boxEstado.Text, tit, tit1, tit2, tit3, tit4, tit5);
                  //  dataGridViewResultados.DefaultCellStyle.BackColor = Color.Cyan;

                    dataGridViewResultados.Rows.Add(boxEstado.Text, mvaO, mva4, mva7, mva12, aliq, fecp);

                    dataGridViewResultados.Rows.Add(boxEstado.Text, T1, T2, T3, T4, T5, T6);

                    dataGridViewResultados.Rows.Add(boxEstado.Text, C1, C2, C3, C4, C5, C6);

                    
                    driver.Close();
                    driver.Quit();

                }
                catch
                {
                    MessageBox.Show("É preciso colocar NCM ou CEst " );
                }


                if ((boxEstado.SelectedIndex % 3) == 0 || boxEstado.Text == "TO") { break; return; }
                else
                {


                    boxEstado.SelectedIndex++;
                }


            }
            // limpar a caixa 
            txtCest1.Clear();
            txtNcm.Clear();
            txtncm2.Clear();
            txtncm2.Text = "00";
            MessageBox.Show("Pesquisa concluida");
       
        }
        #region Marca d'água

        private void ncmEnter(object sender, EventArgs e)
        {
            if (txtNcm.Text == "4 N° ncm : 2106")
            {
                txtNcm.Text = "";

                txtNcm.ForeColor = Color.Black;
            }
        }

        private void ncm2Enter(object sender, EventArgs e)
        {
            if (txtncm2.Text == "00")
            {
                txtncm2.Text = "";

                txtncm2.ForeColor = Color.Black;
            }
        }
        #endregion

    }
}
