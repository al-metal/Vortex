using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Расчет_моющих_средств
{
    public partial class Klining : Form
    {
        #region Поверхность
        string[] kuh = new string[14]
        {
            "Посуда, противни, сковороды" ,
            "Посудомоечная машина" ,
            "Холодильник" ,
            "Вытяжка" ,
            "Плита, гриль, духовка",
            "Микроволновая печь",
            "Столовые приборы",
            "Моечная ванна" ,
            "Общая дезинфекция" ,
            "Рабочие столы и поверхности",
            "Мойка и чистка" ,
            "Трубы" ,
            "Устранение запахов" ,
            "Гигиена рук"
        };

        string[] sanusel = new string[7]
        {
            "Унитаз, биде, писсуар, раковина",
            "Ванна, душевая кабина",
            "Окна, стекла, зеркала",
            "Мойка и чистка",
            "Трубы",
            "Устранение запахов",
            "Гигиена рук"
        };

        string[] uborkaoffice = new string[6]
        {
            "Оргтехника",
            "Мягкая мебель",
            "Деревянная мебель",
            "Окна, стекла, зеркала",
            "Мойка и чистка",
            "Общая дезинфекция"
        };

        string[] obshklining = new string[8]
        {
            "Оргтехника",
            "Мягкая мебель",
            "Деревянная мебель",
            "Окна, стекла, зеркала",
            "Мойка и чистка",
            "Общая дезинфекция",
            "Гигиена рук",
            "Устранение запахов"
        };

        string[] remont = new string[3]
        {
            "Гигиена рук",
            "Окна, стекла, зеркала",
            "Мойка и чистка"
        };

        #endregion

        #region Проблема

            #region Кухня
        string[] kuhPosuda = new string[3]
        {
            "Для замачивания" ,
            "Против гари и копоти" ,
            "Для отбеливания и дезинфекции"
        };

        string[] kuhPosudMashin = new string[2]
        {
            "Для мойки" ,
            "Для ополаскивания"
        };

        string[] kuhHolodil = new string[2]
        {
            "Внутри" ,
            "Снаружи"
        };

        string[] kuhVityajka = new string[2]
        {
            "Обезжиривание" ,
            "Блеск"
        };

        string[] kuhMoika = new string[5]
        {
            "Стены, двери" ,
            "Напольные покрытия" ,
            "Окна и зеркала",
            "Мусорные баки" ,
            "Отбеливание мопов и полотенец"
        };

        string[] kuhTrub = new string[1]
        {
            "Устранение засоров"
        };

        string[] kuhRuki = new string[2]
        {
            "Жидкое мыло" ,
            "Антисептик"
        };
        #endregion

            #region Санузел
        string[] sanuselUnitaz = new string[7]
        {
            "Ржавчина",
            "Мочевой, водный камень",
            "Известковый налет",
            "Плесень, грибок",
            "Потожировые загрязнения",
            "Органика, микробы",
            "Дезинфекция"
        };

        string[] sanuselVanna = new string[4]
        {
            "Потожировые и мыльные",
            "Известковый налет",
            "Ржавые подтеки",
            "Отбеливание и дезинфекция"
        };
        string[] sanuselMoyka = new string[4]
        {
            "Стены, двери",
            "Напольные покрытия",
            "Мусорные баки",
            "Плафоны"
        };
        string[] sanuselTrub = new string[1]
        {
            "Устранение засоров"
        };

        string[] sanuselRuki = new string[2]
        {
            "Жидкое мыло",
            "Антисептик"
        };
        #endregion

        #endregion

        #region Средства

        #region Кухня
        string[] kuhPosudaZamach = new string[2]
        {
            "Marvel" ,
            "Optima Gel"
        };

        string[] kuhPosudaGar = new string[1]
        {
            "Daze"
        };

        string[] kuhPosudaOtbel = new string[1]
        {
            "Fumigel"
        };

        string[] kuhPosudЬMashinMoika = new string[1]
        {
            "Blank"
        };

        string[] kuhPosudЬMashinOpolask = new string[1]
        {
            "DeBlank"
        };

        string[] kuhHolodilVnutr = new string[0]
        {

        };

        string[] kuhHolodilsnaru = new string[3]
        {
            "Optima" ,
            "Optima Gel",
            "Well"
        };

        string[] kuhVityajkaObez = new string[2]
        {
            "Daze" ,
            "Well"
        };

        string[] kuhVityajkaBlesk = new string[1]
        {
            "Twist"
        };

        string[] kuhPlita = new string[1]
        {
            "Daze"
        };

        string[] kuhSVCH = new string[2]
        {
            "Daze",
            "Well"
        };

        string[] kuhPribor = new string[2]
        {
            "Marvel",
            "Optima Gel"
        };

        string[] kuhMoechVanna = new string[1]
        {
            "Fumigel"
        };

        string[] kuhObDezinfec = new string[1]
        {
            "Fumigel"
        };

        string[] kuhRabStol = new string[2]
        {
            "Optima",
            "Optima Gel"
        };

        string[] kuhMoikaSteny = new string[2]
        {
            "Optima" ,
            "Optima Gel"
        };

        string[] kuhMoikaNapol = new string[2]
        {
            "Comfort" ,
            "Comfort Extra"
        };

        string[] kuhMoikaOkna = new string[1]
        {
            "Magic"
        };

        string[] kuhMoikMusorBaki = new string[3]
        {
            "Optima",
            "Optima Gel",
            "Fumigel"
        };

        string[] kuhMoikOtbelMopov = new string[1]
        {
            "Fumigel"
        };

        string[] kuhTrubZasor = new string[1]
        {
            "Draft"
        };

        string[] kuhZapah = new string[2]
        {
            "Block",
            "Fog"
        };

        string[] kuhRukiMylo = new string[3]
        {
            "Joy" ,
            "Joy Platinum",
            "Fay"
        };

        string[] kuhRukiAntysept = new string[1]
        {
            "Joy Sept"
        };
        #endregion

        #region санузел

        string[] sanuselUnitazRjav = new string[1]
        {
            "Breeze"
        };

        string[] sanuselUnitazVodkamen = new string[1]
        {
            "Breeze"
        };

        string[] sanuselUnitazIzvestnalet = new string[1]
        {
            "Breeze"
        };

        string[] sanuselUnitazPlesen = new string[1]
        {
            "Fumigel"
        };

        string[] sanuselUnitazPotojir = new string[2]
        {
            "Breeze",
            "Fumigel"
        };

        string[] sanuselUnitazOrganika = new string[2]
        {
            "Breeze",
            "Fumigel"
        };

        string[] sanuselUnitazDezinfek = new string[1]
        {
            "Fumigel"
        };

        string[] sanuselVannaPot = new string[2]
        {
            "Breeze",
            "Fumigel"
        };

        string[] sanuselVannaIzvestNalet = new string[1]
        {
            "Breeze"
        };

        string[] sanuselVannaRjavpodtek = new string[1]
        {
            "Breeze"
        };

        string[] sanuselVannaOtbel = new string[1]
        {
            "Fumigel"
        };

        string[] sanuselOkna = new string[1]
        {
            "Magic"
        };

        string[] sanuselMoykaSten = new string[2]
        {
            "Optima",
            "Optima Gel"
        };

        string[] sanuselMoykaPol = new string[2]
        {
            "Comfort",
            "Comfort Extra"
        };

        string[] sanuselMoykaBaki = new string[3]
        {
            "Optima",
            "Optima Gel",
            "Fumigel"
        };

        string[] sanuselMoykaPlafon = new string[3]
        {
            "Twist",
            "Optima",
            "Optima Gel"
        };

        string[] sanuselTrubZasor = new string[1]
        {
            "Draft"
        };

        string[] sanuselZapah = new string[1]
        {
            "Block"
        };

        string[] sanuselRukiMylo = new string[3]
        {
            "Joy",
            "Joy Platinum",
            "Fay"
        };
        string[] sanuselRukiAntisept = new string[1]
        {
            "Joy Sept"
        };

        #endregion

        #endregion

        public Klining()
        {
            InitializeComponent();
        }

        private void Klining_FormClosing(object sender, FormClosingEventArgs e)
        {
            Vortex vortex = new Vortex();
            vortex.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int combobox1item = 0;
            comboBox2.Enabled = true;
            if (comboBox1.SelectedIndex == 0)
            {
                ItemsAddCB2(kuh);
                combobox1item = 0;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                ItemsAddCB2(sanusel);
                combobox1item = 1;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                ItemsAddCB2(uborkaoffice);
                combobox1item = 2;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                ItemsAddCB2(obshklining);
                combobox1item = 3;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                ItemsAddCB2(remont);
                combobox1item = 4;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                combobox1item = 4;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Enabled = true;

            #region Кухня
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
            {
                ItemsAddCB3(kuhPosuda);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
            {
                ItemsAddCB3(kuhPosudMashin);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)
            {
                ItemsAddCB3(kuhHolodil);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 3)
            {
                ItemsAddCB3(kuhVityajka);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 4)
            {
                ResultShowNoneCB3(kuhPlita);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 5)
            {
                ResultShowNoneCB3(kuhSVCH);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 6)
            {
                ResultShowNoneCB3(kuhPribor);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 7)
            {
                ResultShowNoneCB3(kuhMoechVanna);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 8)
            {
                ResultShowNoneCB3(kuhObDezinfec);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 9)
            {
                ResultShowNoneCB3(kuhRabStol);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 10)
            {
                ItemsAddCB3(kuhMoika);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 11)
            {
                ItemsAddCB3(kuhTrub);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 12)
            {
                ResultShowNoneCB3(kuhZapah);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 13)
            {
                ItemsAddCB3(kuhRuki);
            }
            #endregion

            #region Санузел

            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                ItemsAddCB3(sanuselUnitaz);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
            {
                ItemsAddCB3(sanuselVanna);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
            {
                ResultShowNoneCB3(sanuselOkna);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 3)
            {
                ItemsAddCB3(sanuselMoyka);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 4)
            {
                ItemsAddCB3(sanuselTrub);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 5)
            {
                ResultShowNoneCB3(sanuselZapah);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 6)
            {
                ItemsAddCB3(sanuselRuki);
            }
            #endregion

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Кухня
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0 && comboBox3.SelectedIndex == 0)
            {
                ResultShow(kuhPosudaZamach);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0 && comboBox3.SelectedIndex == 1)
            {
                ResultShow(kuhPosudaGar);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0 && comboBox3.SelectedIndex == 2)
            {
                ResultShow(kuhPosudaOtbel);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1 && comboBox3.SelectedIndex == 0)
            {
                ResultShow(kuhPosudЬMashinMoika);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1 && comboBox3.SelectedIndex == 1)
            {
                ResultShow(kuhPosudЬMashinOpolask);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2 && comboBox3.SelectedIndex == 0)
            {
                ResultShow(kuhHolodilVnutr);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2 && comboBox3.SelectedIndex == 1)
            {
                ResultShow(kuhHolodilsnaru);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 3 && comboBox3.SelectedIndex == 0)
            {
                ResultShow(kuhVityajkaObez);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 3 && comboBox3.SelectedIndex == 1)
            {
                ResultShow(kuhVityajkaBlesk);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 10 && comboBox3.SelectedIndex == 0)
            {
                ResultShow(kuhMoikaSteny);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 10 && comboBox3.SelectedIndex == 1)
            {
                ResultShow(kuhMoikaNapol);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 10 && comboBox3.SelectedIndex == 2)
            {
                ResultShow(kuhMoikaOkna);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 10 && comboBox3.SelectedIndex == 3)
            {
                ResultShow(kuhMoikMusorBaki);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 10 && comboBox3.SelectedIndex == 4)
            {
                ResultShow(kuhMoikOtbelMopov);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 11 && comboBox3.SelectedIndex == 0)
            {
                ResultShow(kuhTrubZasor);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 13 && comboBox3.SelectedIndex == 0)
            {
                ResultShow(kuhRukiMylo);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 13 && comboBox3.SelectedIndex == 1)
            {
                ResultShow(kuhRukiAntysept);
            }
            #endregion

            #region Санузел

            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0 && comboBox3.SelectedIndex == 0)
            {
                ResultShow(sanuselUnitazRjav);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0 && comboBox3.SelectedIndex == 1)
            {
                ResultShow(sanuselUnitazVodkamen);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0 && comboBox3.SelectedIndex == 2)
            {
                ResultShow(sanuselUnitazIzvestnalet);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0 && comboBox3.SelectedIndex == 3)
            {
                ResultShow(sanuselUnitazPlesen);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0 && comboBox3.SelectedIndex == 4)
            {
                ResultShow(sanuselUnitazPotojir);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0 && comboBox3.SelectedIndex == 5)
            {
                ResultShow(sanuselUnitazOrganika);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0 && comboBox3.SelectedIndex == 6)
            {
                ResultShow(sanuselUnitazDezinfek);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1 && comboBox3.SelectedIndex == 0)
            {
                ResultShow(sanuselVannaPot);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1 && comboBox3.SelectedIndex == 1)
            {
                ResultShow(sanuselVannaIzvestNalet);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1 && comboBox3.SelectedIndex == 2)
            {
                ResultShow(sanuselVannaRjavpodtek);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1 && comboBox3.SelectedIndex == 3)
            {
                ResultShow(sanuselVannaOtbel);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 3 && comboBox3.SelectedIndex == 0)
            {
                ResultShow(sanuselMoykaSten);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 3 && comboBox3.SelectedIndex == 1)
            {
                ResultShow(sanuselMoykaPol);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 3 && comboBox3.SelectedIndex == 2)
            {
                ResultShow(sanuselMoykaBaki);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 3 && comboBox3.SelectedIndex == 3)
            {
                ResultShow(sanuselMoykaPlafon);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 4 && comboBox3.SelectedIndex == 0)
            {
                ResultShow(sanuselTrubZasor);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 6 && comboBox3.SelectedIndex == 0)
            {
                ResultShow(sanuselRukiMylo);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 6 && comboBox3.SelectedIndex == 1)
            {
                ResultShow(sanuselRukiAntisept);
            }
            #endregion

        }


        private void ItemsAddCB2(string[] array)
        {
            comboBox2.Items.Clear();
            foreach (string str in array)
                comboBox2.Items.Add(str);
        }

        private void ItemsAddCB3(string[] array)
        {
            comboBox3.Items.Clear();
            foreach (string str in array)
                comboBox3.Items.Add(str);
        }

        private void ResultShow(string[] array)
        {
            textBox1.Clear();
            foreach (string str in array)
                textBox1.AppendText(str + "\n");
        }

        private void ResultShowNoneCB3(string[] array)
        {
            textBox1.Clear();
            comboBox3.SelectedIndex = -1;
            comboBox3.Items.Clear();
            comboBox3.Enabled = false;
            foreach (string str in array)
                textBox1.AppendText(str + "\n");
        }
    }
}
