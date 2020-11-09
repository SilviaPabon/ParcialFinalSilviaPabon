using FirstFantasy.Classes;
using FirstFantasy.Classes.Equipment;
using FirstFantasy.Classes.Player;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstFantasy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {

            Character myCharacter;

            string option = CboxCharacter.Text;

            switch (option)
            {
                case "Cleric":
                    myCharacter = new Cleric();
                    myCharacter.Race = Character.Races.Cleric;
                    break;

                case "Fighter":
                    myCharacter = new Fighter();
                    myCharacter.Race = Character.Races.Fighter;
                    break;

                case "Rouge":
                    myCharacter = new Rouge();
                    myCharacter.Race = Character.Races.Rouge;
                    break;

                case "Wizard":
                    myCharacter = new Wizard();
                    myCharacter.Race = Character.Races.Wizard;
                    break;

                default:
                    myCharacter = null;
                    MessageBox.Show("You MUST select a type");
                    break;
            }

            myCharacter.Name = txtNombrep.Text;

            lboxPersonajes.Items.Add(myCharacter).ToString();

            txtNombrep.Text = "";
            CboxCharacter.Text = "";
        }

        private void btnAgregarArma_Click(object sender, RoutedEventArgs e)
        {

            Character seleccionado; 

            seleccionado = (Character) lboxPersonajes.SelectedItem;
            

            if (seleccionado == null)
            {
                MessageBox.Show("You MUST pick");
                return;
            }

            Weapon myWeapon;

            string option2 = cboxWeapon.Text;

            switch (option2)
            {
                case "Axe":
                    myWeapon = new Axe();
                    myWeapon.NombreObjeto = "Hacha";
                    myWeapon.Damage = myWeapon.Attack();
                    myWeapon.TipoObjeto = "Arma";
                    string descripcion = myWeapon.Descripcion;
                    break;

                case "Sword":
                    myWeapon = new Sword();
                    myWeapon.NombreObjeto = "Espada";
                    myWeapon.TipoObjeto = "Arma";
                    myWeapon.Damage = myWeapon.Attack();
                    break;

                case "Hammer":
                    myWeapon = new Hammer();
                    myWeapon.NombreObjeto = "Martillo";
                    myWeapon.TipoObjeto = "Arma";
                    myWeapon.Damage = myWeapon.Attack();
                    break;

                default:
                    myWeapon = null;
                    MessageBox.Show("You MUST select a type");
                    break;
            }

            seleccionado.AddArma(myWeapon);
            dgArmas.ItemsSource = seleccionado.Armas;
            dgArmas.Items.Refresh();
            cboxWeapon.Text = "";
        }



        private void lboxPersonajes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            Character seleccionado;

            seleccionado = (Character)lboxPersonajes.SelectedItem;

            
            if (seleccionado == null)
            {
                MessageBox.Show("You MUST pick");
                return;
            }
            
            dgArmas.ItemsSource = seleccionado.Armas;

        }

        private void btnAgregarArmadura_Click(object sender, RoutedEventArgs e)
        {
            Character seleccionado;

            seleccionado = (Character)lboxPersonajes.SelectedItem;


            if (seleccionado == null)
            {
                MessageBox.Show("You MUST pick");
                return;
            }

            ObjetoI myInventary;

            string option3 = cboxArmor.Text;

            switch (option3)
            {
                case "Armor Gold":
                    myInventary = new Gold();
                    myInventary.NombreObjeto = "Armadura de Oro";
                    myInventary.TipoObjeto = "Armadura";

                    break;

                case "Armor Silver":
                    myInventary = new Silver();
                    myInventary.NombreObjeto = "Armadura de Plata";
                    myInventary.TipoObjeto = "Armadura";
                    break;

                case "EntDraught":
                    myInventary = new EntDraught();
                    myInventary.NombreObjeto = "Bebidas de los Ents";
                    myInventary.TipoObjeto = "Poción";
                    break;

                case "LucysCordial":
                    myInventary = new LucysCordial();
                    myInventary.NombreObjeto = "Poción de Lucy";
                    myInventary.TipoObjeto = "Poción";
                    break;

                default:
                    myInventary = null;
                    MessageBox.Show("You MUST select a type");
                    break;
            }

            seleccionado.AddObjetos(myInventary);
            seleccionado.Inventario.ForEach(Weapon => seleccionado.Armas.Add(Weapon));
            seleccionado.Inventario.Clear();
            dgArmas.ItemsSource = seleccionado.Armas;
            dgArmas.Items.Refresh();
            cboxArmor.Text = "";
        }

        private void btnAttack_Click(object sender, RoutedEventArgs e)
        {
            int suma = 0;

            for(int i = 0; i < dgArmas.Items.Count; i++)
            {
                suma += (int.Parse((dgArmas.Columns[1].GetCellContent(dgArmas.Items[i])as TextBlock).Text));
            }

            MessageBox.Show("El ataque de " + lboxPersonajes.SelectedItem.ToString() + " fue de " + suma.ToString() + " puntos.");
        }
    }
    }

