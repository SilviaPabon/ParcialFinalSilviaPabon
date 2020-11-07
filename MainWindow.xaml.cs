using FirstFantasy.Classes;
using FirstFantasy.Classes.Equipment;
using FirstFantasy.Classes.Player;
using FirstFantasy.Extra;
using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
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
            List<Character> characterList = new List<Character>();

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



            /*
            txtOutput.Text += fighter.ShowCharacter();

            Cleric cleric = new Cleric();

            cleric.Name = "Solrac";
            cleric.Level = 20;
            cleric.Experience = 30000;
            

            txtOutput.Text += cleric.ShowCharacter();
            txtOutput.Text += cleric.Taunt();

            */

            //Sword mySword = new Sword();

            //txtOutput.Text = mySword.Attack(3);

            // List<IDescribable> objectList = new List<IDescribable>();
            //objectList.Add(new Axe());
            //objectList.Add(new Potion());
            //objectList.Add(new Wizard()); // se que tienen todas show information por lo que son lista de IDescribible

            //IDescribable i = new Fighter();
            //IAccount ic;

            //ic.Register("Carlos", 12345); //arroja un booleano gracias a la interface, linea 9 IRegister

            // las interfaces se usan para polimorfismo, para los contratos también que si no están no permiten funcionar a la app

            //foreach (IDescribable d in objectList)
            //{

            //txtOutput.Text += d.ShowInformation();
            //}

            /* clase 3 de octubre Fighter fighter = new Fighter();

            fighter.Name = "Solrac";
            fighter.Level = 20;
            fighter.Experience = 30000;

            txtOutput.Text += fighter.ShowCharacter();

            Cleric cleric = new Cleric();

            cleric.Name = "Solrac";
            cleric.Level = 20;
            cleric.Experience = 30000;

            txtOutput.Text += cleric.ShowCharacter();
            txtOutput.Text += cleric.Taunt();
            */

            // String option = CboxCharacter.Text;

            /*List<Character> characterList = new List<Character>(); //Parte de interfaces

            Cleric cleric = new Cleric();
            cleric.Name = "María";
            cleric.Level = 1;
            cleric.Experience = 0;

            Rouge rouge = new Rouge { Name = "Silvia", Level = 1, Experience = 0 };

            characterList.Add(cleric);
            characterList.Add(rouge);
            characterList.Add(new Fighter { Name = "Jean", Level = 1, Experience = 0 });
            characterList.Add(new Wizard { Name = "Miguel", Level = 1, Experience = 100 });

            txtOutput.Text = "";*/


            // para utilizar sort con objetos aclarar criterio de comparación


            // clase 3 de octubre:
            // POO si hay muchos if, menos elegante y no se está haciendo bien
            /*foreach (Character c in characterList)
            {
                
                txtOutput.Text += c.ShowCharacter();
            }

            */
            /*
            

            // Para que fighter no arroje error
            myCharacter.Name = "Solrac";
            myCharacter.Level = 2;
            myCharacter.Experience = 10000;

            if (myCharacter != null)
            {
                txtOutput.Text = myCharacter.Taunt();


                // ((Wizard)myCharacter).CastSpell(); sólo funciona si es Wizard de resto error, muy delicado.
                // txtOutput.Text = myCharacter.CastSpell(); no funciona porque lo tiene Wizard mas no Character
            la solución no es ir a ponerlo en characters, en esto ayuda interfaces, o castear como en 128, pero el problema es si
            funciona con wizard pero con los otros no
            */

        }

        private void btnAgregarArma_Click(object sender, RoutedEventArgs e)
        {
            Character personajeSeleccion;

            personajeSeleccion = (Character)lboxPersonajes.SelectedItem;

            if(personajeSeleccion == null)
            {
                MessageBox.Show("You MUST select a type");
                return;
            }

            Weapon myWeapon;

            string option2 = cboxWeapon.Text;

            switch (option2)
            {
                case "Axe":
                    myWeapon = new Axe();
                    break;

                case "Sword":
                    myWeapon = new Sword();
                    break;

                case "Hammer":
                    myWeapon = new Hammer();
                    break;

                default:
                    myWeapon = null;
                    MessageBox.Show("You MUST select a type");
                    break;
            }

            personajeSeleccion = (Character)lboxPersonajes.SelectedItem;




        }


    }
    }

