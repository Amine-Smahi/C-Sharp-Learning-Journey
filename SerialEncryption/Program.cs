using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace SerialEncryption {
    class Program {
        static void Main (string[] args) {
            var mymac = GetMACAddress ();
            char[] characters = mymac.ToCharArray ();
            List<string> key = Crypt (characters);
            Console.Write ("Your key is : ");
            for (int i = 0; i < key.Count; i++) {
                Console.Write (key[i]);
                if (i < key.Count - 1) {
                    Console.Write ("-");
                }
            }
            Console.WriteLine ("\nEnter a key");
            if (decrypte (Console.ReadLine ())) {
                Console.WriteLine ("\nWelcome");
            } else {
                Console.WriteLine ("\nWrong Key");
            }
        }
        public static string GetMACAddress () {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces ();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics) {
                if (sMacAddress == String.Empty) // only return MAC Address from first card
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties ();
                    sMacAddress = adapter.GetPhysicalAddress ().ToString ();
                }
            }
            return sMacAddress;
        }
        public static System.Int64 Calculator (int x) {
            System.Int64 s = 0;
            s = Convert.ToInt32 ((2 * Math.Pow (x, 2)) - (3 * x) - 24);
            return s;
        }
        public static List<string> Crypt (char[] characters) {
            int[] asci = new int[12];
            for (int i = 0; i < characters.Length; i++) {
                asci[i] = (int) Convert.ToChar (characters[i]);
            }
            List<int> newList = new List<int> ();

            int k = 0;
            for (int i = 0; i < 6; i++) {
                newList.Add (2 * (asci[k] + asci[k + 1]));
                k = k + 2;
            }

            List<string> key = new List<string> ();

            for (int i = 0; i < newList.Count; i++) {
                key.Add (Calculator (newList[i]).ToString ("X"));
            }
            return key;
        }
        public static bool decrypte (string userKey) {
            var mymac = GetMACAddress ();
            char[] characters = mymac.ToCharArray ();
            List<string> key = Crypt (characters);
            var userArray = userKey.Split ('-');
            for (int i = 0; i < key.Count; i++) {
                if (key[i] != userArray[i]) {
                    return false;
                }
            }
            return true;
        }
    }
}