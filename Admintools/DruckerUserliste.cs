#region "Using Direktiven"
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
#endregion

namespace Admintools
{

    public partial class DruckerUserliste : Form
    {
        #region "Globale Variablen"
       

         // Zähler für die anzahl der Benutzer
        private int i = 1;
        // Dim Pfad As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\UserlisteMitEmailScan.txt"
        private string Pfad = Application.StartupPath + @"\UserlisteMitEmailScan.txt";
        private string PfadCSV = Application.StartupPath;
        #endregion

        #region "Initialize"
        public DruckerUserliste()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadEreignis
        private void DruckerUserliste_Load(object sender, EventArgs e)
        {
         
            this.Location = new Point(frmHauptprogramm.MousePosition.X, frmHauptprogramm.MousePosition.Y);

            if (File.Exists(PfadCSV + @"\UserlisteMitEmailScan.txt") & File.Exists(PfadCSV + @"\DruckerUserListe.exe.config"))
            {
                this.txtServerSMB.Text = Properties.Settings.Default.ServerSMBPfad;
                this.txtUserHomePfad.Text = Properties.Settings.Default.UserHomePfad;
                this.txtOrganisationseinheit.Text = Properties.Settings.Default.Organisationseinheit;

                foreach (string x in System.IO.File.ReadLines(PfadCSV + @"\UserlisteMitEmailScan.txt"))
                    rtbUsermitMail.AppendText(x + Environment.NewLine);
            }
            else
            {
                File.WriteAllText(PfadCSV + @"\UserlisteMitEmailScan.txt", Properties.Resources.Userliste);
                File.WriteAllText(PfadCSV + @"\DruckerUserListe.exe.config", Properties.Resources.Config);

                this.txtServerSMB.Text = Properties.Settings.Default.ServerSMBPfad;
                this.txtUserHomePfad.Text = Properties.Settings.Default.UserHomePfad;
                this.txtOrganisationseinheit.Text = Properties.Settings.Default.Organisationseinheit;

                foreach (string x in System.IO.File.ReadLines(PfadCSV + @"\UserlisteMitEmailScan.txt"))
                    rtbUsermitMail.AppendText(x + Environment.NewLine);
            }
        }
        #endregion
        
        #region "daten aus AD"
        public void DatenAusAd()
        {

            try
            {

                // Deklaration für das DirectoryEntry
                System.DirectoryServices.DirectoryEntry entry = new System.DirectoryServices.DirectoryEntry(Properties.Settings.Default.Organisationseinheit);
                string DomainDN = System.Convert.ToString(entry.Properties["DefaultNamingContext"].Value);
                System.DirectoryServices.DirectoryEntry ADEntry = new System.DirectoryServices.DirectoryEntry(Properties.Settings.Default.Organisationseinheit + DomainDN);
                System.DirectoryServices.DirectorySearcher mySearcher = new System.DirectoryServices.DirectorySearcher(ADEntry);
 

                mySearcher.Filter = "(& (objectCategory=Person)(objectClass=user)(sAMAccountName=*" + "*.*" + "))";

                string VollenUserNamen = Environment.UserName;
                string User = VollenUserNamen.Remove(0, 2); // Barthelmes
                Font SchriftMuliFett10 = new Font("Muli", 10.0F);

                // StandardText in der csv datei m übernommen aus der Originaldatei
                string StandardText = "#Registrationsdaten" + Environment.NewLine + "#Format Version:3.1.6.0"
                    + Environment.NewLine + "#Exportdatum: 07/14/2018 10:39:49" + Environment.NewLine + "#Gerätename:" + Environment.NewLine
                    + "#Adresse:" + Environment.NewLine + "#Registrations-Nr.,Typ,Name,Anwendernamen-Anzeige,Index,Oft,Titel 1,Titel 2,Titel 3,E-Mail-Adresse,Name verwenden als,Absender schützen,Passwort,Anwendercode/Gerätelogin-Anwendername,Gruppen, denen der Anwender angehört,Destinazione fax,Faxziel,Linientyp,Internationaler Übertragungsmodus,Fax-Header,Name einfügen 1. Zeile (Wahl),Name einfügen 2. Zeile (Zeichenkette),Ordner schützen,Passwort-Verschlüsselung,Protokoll,Anschluss-Nr.,Servername,Pfad,Anwendername,Japanischer Zeichencode,Zugriffsprivileg auf Anwender,Zugriffsprivileg auf Geschützte Dateien,IP-Faxprotokoll,IP-Faxziel,Login-Passwort für Gerät,Passwortverfahren,SMTP-Authentifizierung,SMTP-Authentifizierung: Login-Anwendername,SMTP-Authentifizierung: Login-Passwort,Passwortverfahren,Ordner-Authentifizierung,Ordner-Authentifizierung: Login-Passwort,Passwortverfahren,LDAP-Authentifizierung,LDAP-Authentifizierung: Login-Anwendername,LDAP-Authentifizierung: Login-Passwort,Passwortverfahren,Direkt SMTP,Anzeigepriorität" + Environment.NewLine
                    + "<index>,<type>,<name>,<displayName>,<phoneticName>,<common>,<tagSet1>,<tagSet2>,<tagSet3>,<address>,<isSender>,<protect>,<password>,<userCode>,<group>,<faxNumber>,<lineType>,<isAbroad>,<ttiNo>,<label1>,<label2String>,<messageNo>,<protectFolder>,<passwordEncoding>,<folderProtocol>,<ftpPort>,<folderServer>,<folderPath>,<folderUser>,<ftpCharCoding>,<entryACL>,<documentACL>,<IPfaxProtocol>,<IPfaxAddress>,<authPassword>,<passwordEncoding2>,<SMTPAuth>,<SMTPUser>,<SMTPPassword>,<passwordEncoding3>,<folderAuth>,<folderPassword>,<passwordEncoding4>,<LDAPAuth>,<LDAPUser>,<LDAPPassword>,<passwordEncoding5>,<DirectSMTP>,<displayPriority>" + Environment.NewLine;


                // Standardeinträge einer .csv datei generieren
                this.TextBox4.AppendText(StandardText);

                // Für jeden eintrag in der AD, erstelle einen String und schreibe in die Textbox
                foreach (System.DirectoryServices.SearchResult resEnt in mySearcher.FindAll())
                {
                    System.DirectoryServices.DirectoryEntry de = resEnt.GetDirectoryEntry();

                    // Deklarationen
                    string Username = de.Properties["samAccountName"].Value.ToString();
                    string value = Username;
                    int startIndex = 2;
                    int length = 1;
                    string substring = value.Substring(startIndex, length);
                    int NamenstastenNummer = 0;
                    string DruckerStringOhneEmail = "";
                    // Den Usernamen müssen wir noch Formatieren: aus h.barthelmes wird H. Barthelmes
                    string substring2 = Username.Substring(0, 1).ToUpper() + Username.Substring(1); // Wir schreiben das H góß
                    string substring3 = Username.Substring(0, 3).ToUpper() + Username.Substring(3); // Wir schreiben das B Groß
                    string substring4 = Username.Substring(0, 3).ToUpper() + Username.Substring(3);
                    string original = substring4;
                    string modifiedUsername = original.Insert(2, " "); // der punkt wird durch ein leerzeichen ersetzt

                    // Hier werden die Nachnamen den Namenstasten zugeordnet AB = 1 BC = 2 DE
                    if (substring == "a" | substring == "ä" | substring == "b")
                        NamenstastenNummer = 1;
                    else if (substring == "c" | substring == "d")
                        NamenstastenNummer = 2;
                    else if (substring == "e" | substring == "f")
                        NamenstastenNummer = 3;
                    else if (substring == "g" | substring == "h")
                        NamenstastenNummer = 4;
                    else if (substring == "i" | substring == "j" | substring == "k")
                        NamenstastenNummer = 5;
                    else if (substring == "l" | substring == "m" | substring == "n")
                        NamenstastenNummer = 6;
                    else if (substring == "o" | substring == "ö" | substring == "p" | substring == "q")
                        NamenstastenNummer = 7;
                    else if (substring == "r" | substring == "s" | substring == "t")
                        NamenstastenNummer = 8;
                    else if (substring == "u" | substring == "ü" | substring == "v" | substring == "w")
                        NamenstastenNummer = 9;
                    else if (substring == "x" | substring == "y" | substring == "z")
                        NamenstastenNummer = 10;
                    else
                        NamenstastenNummer = 1;// Falls der name ein umlaut hat, wird der wert der Namenstaste auf 1  gesetzt

                    // Dim KurzerName As String = modifiedUsername.Substring(0, 5)

                    if (modifiedUsername.Count() - 1 > 12)
                        DruckerStringOhneEmail = "[" + i + "], [A],[" + modifiedUsername + "],[" + modifiedUsername.Substring(0, 11) + "],,[0],[" + NamenstastenNummer + "],[0],[0],,[0],,,,,,,,,,,,[0], [omitted],[0],,,[" + Properties.Settings.Default.UserHomePfad + "" + Username + "],,,,,,,, [omitted],[0],,, [omitted],[2],, [omitted],[0],,, [omitted],,[5]";
                    else
                        DruckerStringOhneEmail = "[" + i + "], [A],[" + modifiedUsername + "],[" + modifiedUsername + "],,[0],[" + NamenstastenNummer + "],[0],[0],,[0],,,,,,,,,,,,[0], [omitted],[0],,,[" + Properties.Settings.Default.UserHomePfad + "" + Username + "],,,,,,,, [omitted],[0],,, [omitted],[2],, [omitted],[0],,, [omitted],,[5]";


                    this.TextBox4.AppendText(DruckerStringOhneEmail + Environment.NewLine);

                    // Zähler hochzählen
                    i = i + 1;
                }


                List<string> UserMitEmail = new List<string>();
                List<string> MeinArray = new List<string>();
                if (System.IO.File.Exists(Pfad) == true)
                {
                    using (System.IO.StreamReader StreamReader = new System.IO.StreamReader(Pfad))
                    {
                        do
                            MeinArray.Add(StreamReader.ReadLine());
                        while (StreamReader.Peek() < 0);
                    }
                    foreach (string Zeile in MeinArray)
                        UserMitEmail.Add(Zeile);
                }
                else
                {
                }

                System.DirectoryServices.DirectoryEntry entry2 = new System.DirectoryServices.DirectoryEntry(Properties.Settings.Default.Organisationseinheit);
                string DomainDN2 = System.Convert.ToString(entry2.Properties["DefaultNamingContext"].Value);
                System.DirectoryServices.DirectoryEntry ADEntry2 = new System.DirectoryServices.DirectoryEntry(Properties.Settings.Default.Organisationseinheit + DomainDN2);
                System.DirectoryServices.DirectorySearcher mySearcher2 = new System.DirectoryServices.DirectorySearcher(ADEntry2);
                System.DirectoryServices.SearchResultCollection oResults2;
     

   

                try
                {
                    // Für jeden eintrag in der AD, erstelle einen String und schreibe in die Textbox
                        foreach (string mitarbeiter in rtbUsermitMail.Lines)
                    {
                        if (mitarbeiter != "")
                        {


                        mySearcher2.Filter = "(& (objectClass=Person)(sAMAccountName=*" + mitarbeiter + "))";
                        oResults2 = mySearcher2.FindAll();



                        // Für jeden eintrag in der AD, erstelle einen String und schreibe in die Textbox
                        foreach (System.DirectoryServices.SearchResult resEnt in mySearcher2.FindAll())
                        {
                            // Deklarationen
                            System.DirectoryServices.DirectoryEntry de = resEnt.GetDirectoryEntry();
                            // Deklarationen
                            string Email = de.Properties["mail"].Value.ToString();
                            string Username = de.Properties["samAccountName"].Value.ToString();

                            string value = Username;
                            int startIndex = 2;
                            int length = 1;
                            string substring = value.Substring(startIndex, length);
                            int NamenstastenNummer = 0;
                            string DruckerStringMitDrucker = "";

                            // Den Usernamen müssen wir noch Formatieren: aus h.barthelmes wird H. Barthelmes
                            string substring2 = Username.Substring(0, 1).ToUpper() + Username.Substring(1); // Wir schreiben das H góß
                            string substring3 = Username.Substring(0, 3).ToUpper() + Username.Substring(3); // Wir schreiben das B Groß
                            string substring4 = Username.Substring(0, 3).ToUpper() + Username.Substring(3);
                            string original = substring4;
                            string modifiedUsername = original.Insert(2, " "); // der punkt wird durch ein leerzeichen ersetzt

                            // Hier werden die Nachnamen den Namenstasten zugeordnet AB = 1 BC = 2 DE
                            if (substring == "a" | substring == "ä" | substring == "b")
                                NamenstastenNummer = 1;
                            else if (substring == "c" | substring == "d")
                                NamenstastenNummer = 2;
                            else if (substring == "e" | substring == "f")
                                NamenstastenNummer = 3;
                            else if (substring == "g" | substring == "h")
                                NamenstastenNummer = 4;
                            else if (substring == "i" | substring == "j" | substring == "k")
                                NamenstastenNummer = 5;
                            else if (substring == "l" | substring == "m" | substring == "n")
                                NamenstastenNummer = 6;
                            else if (substring == "o" | substring == "ö" | substring == "p" | substring == "q")
                                NamenstastenNummer = 7;
                            else if (substring == "r" | substring == "s" | substring == "t")
                                NamenstastenNummer = 8;
                            else if (substring == "u" | substring == "ü" | substring == "v" | substring == "w")
                                NamenstastenNummer = 9;
                            else if (substring == "x" | substring == "y" | substring == "z")
                                NamenstastenNummer = 10;
                            else
                                NamenstastenNummer = 1;// Falls der name ein umlaut hat, wird der wert der Namenstaste auf 1  gesetzt

                            // Dim KurzerName As String = modifiedUsername.Substring(0, 5)
                            if (modifiedUsername.Count() - 1 > 12)
                                DruckerStringMitDrucker = "[" + i + "], [A],[" + modifiedUsername + "],[" + modifiedUsername.Substring(0, 11) + "],,[0],[8],[0],[0],[" + Email + "],[0],,,,,,,,[1],,,[0],, [omitted],,,,,,,,,,,, [omitted],[0],,, [omitted],[0],, [omitted],[0],,, [omitted],[0],[5]";
                            else
                                DruckerStringMitDrucker = "[" + i + "], [A],[" + modifiedUsername + "],[" + modifiedUsername + "],,[0],[8],[0],[0],[" + Email + "],[0],,,,,,,,[1],,,[0],, [omitted],,,,,,,,,,,, [omitted],[0],,, [omitted],[0],, [omitted],[0],,, [omitted],[0],[5]";



                            // Dim DruckerStringMitDrucker As String = "[" & i & "], [A],[" & modifiedUsername & "],[" & modifiedUsername & "],,[0],[8],[0],[0],[" & Email & "],[0],,,,,,,,[1],,,[0],, [omitted],,,,,,,,,,,, [omitted],[0],,, [omitted],[0],, [omitted],[0],,, [omitted],[0],[5]"


                            this.TextBox4.AppendText(DruckerStringMitDrucker + Environment.NewLine);

                            // Zähler hochzählen
                            i = i + 1;
                        }
                    }


                    }
                }
                catch
                {

                }
 
            }

            // Änderung an der Fehlerbehandlung vorenommen, mit internetverbindug Testen ob verbindung zu stande kommt
            catch (System.Runtime.InteropServices.COMException ex)
            {

             }
            finally
            {

                // Server wird jedesmal hinzugefügt, kann aber änderungen beinhalten, daher die möglichkeit geben das der User das von aussen ändern kann
                //string Server = "[" + i + "], [A],[Server],[Server],,[1],[0],[1],[1],,[0],,,,,,,,,,,,[0],[omitted],[0],,,[" + Properties.Settings.Default.ServerSMBPfad + @"],,,,,,,,[omitted],[0],,,[omitted],[2],,[omitted],[0],,,[omitted],,[5]";
                //this.TextBox4.AppendText(Server + Environment.NewLine);
                Speichern();
            }
        }

        #endregion

        #region "Speichern"
        public void Speichern()
        {
            try
            {
                   string PfadCSVSpeichern = Application.StartupPath;

                //Prüfen ob der Ordner "Listen" vorhanden ist
                if (!System.IO.Directory.Exists(PfadCSVSpeichern + @"\Listen" ))
                {
                    System.IO.Directory.CreateDirectory(PfadCSVSpeichern + @"\Listen");
                }

        DialogResult dialogResult = MessageBox.Show("Möchten Sie die Daten in eine CSV Datei Exportieren?", "Exportieren?", MessageBoxButtons.YesNo);
                string CurrentTime = System.DateTime.Now.ToString("dd-MM-yyyy");


                if (dialogResult == DialogResult.Yes)
                {
                    Encoding encoding = Encoding.GetEncoding("ISO-8859-1");

                    string s = TextBox4.Text;


                    // Streamwriter mit einer encoding zu UTF8 , das erlaubt das schreiben von deutschen Umlauten
                    StreamWriter sw = new StreamWriter(PfadCSVSpeichern + @"\Listen" + @"\Drucker-Benutzerliste-" + CurrentTime + ".csv", false, encoding);

                    // Datei schfreiben
                    sw.WriteLine(s);

                    // StreamWriter schließen
                    sw.Close();

                    // Messagebox ausgeben mit dem Speicherpfad der csv datei
                    DialogResult dialogResult2 = MessageBox.Show("Die daten wurden Exportiert:" + Environment.NewLine + PfadCSVSpeichern + @"\Listen" + @"\Drucker - Benutzerliste - " + CurrentTime + ".csv", "Pfad Öffnen?", MessageBoxButtons.OKCancel);
                    // WEnn klick auf ok, dann Müll einsammeln u nd anwendung beenden
                    if (dialogResult2 == DialogResult.OK)
                    {
                        //Pfad zur .CSV
                        if (Directory.Exists(PfadCSVSpeichern + @"\Listen"))
                        {
                            try
                            {
                            Process.Start("explorer.exe", PfadCSVSpeichern + @"\Listen");
                            }
                            catch
                            {

                            }
                        
                        }
                    }
                    else if(dialogResult2 == DialogResult.Cancel)
                    {
                        try
                        {
                        }
                        catch (Exception ex)
                        {
                        }
                        GC.Collect();
                        Application.Exit();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    // Müll einsammekb und anwendung schließen
                    GC.Collect();
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                // Fehlerausabe
            }
        }
        #endregion

        #region "Anwendung sauber beenden"
        private void DruckerUserliste_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            frmHauptprogramm frmHaupt = new frmHauptprogramm();
            frmHaupt.Show();

            this.Visible = false;
        }
        #endregion

        #region "Button Klicks"
        private void cmdListeGenerieren_Click(object sender, EventArgs e)
        {
            DatenAusAd();
        }
        #endregion

        #region "Einstellungen Speichern"
        private void cmdSpeichern_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserHomePfad = txtUserHomePfad.Text;
            Properties.Settings.Default.ServerSMBPfad = txtServerSMB.Text;
            Properties.Settings.Default.Organisationseinheit = txtOrganisationseinheit.Text;
            Properties.Settings.Default.Save();
        }

        
        private void rtbUsermitMail_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rtbUsermitMail.SaveFile(Pfad, RichTextBoxStreamType.PlainText);

            }
            catch
            {

            }
        }

        #endregion
 
    }
}