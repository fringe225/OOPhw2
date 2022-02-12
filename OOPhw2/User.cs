using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPhw2
{
    internal class User
    {
        private string _userName;
        private string _password;

        public User(string user, string password)
        {
            UserName = user;
            Password = password;


        }

        public string UserName
        {
            get { return _userName; }
            set
            {
                while (true)
                {
                    if (value.Length < 8)
                    {
                        Console.WriteLine("Username duzgun daxil edin: ");
                        value = Console.ReadLine();
                    }
                    else
                    {
                        _userName = value;
                        break;
                    }
                }
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {


                while (true)
                {
                    if (value.Length < 8)
                    {
                        Console.WriteLine("Parol en azi 8 chardan ibaret olmalidir!");
                        value = Console.ReadLine();
                    }
                    else
                    {
                        bool checkUpper = false;
                        bool checkLower = false;
                        bool checkDigit = false;
                        for (int i = 0; i < value.Length; i++)
                        {
                            if (char.IsUpper(value[i]))
                            {
                                checkUpper = true;
                            }
                            if (char.IsDigit(value[i]))
                            {
                                checkDigit = true;
                            }
                            if (char.IsLower(value[i]))
                            {
                                checkLower = true;
                            }

                        }
                        if (checkUpper && checkLower && checkDigit)
                        {
                            _password = value;
                            break;

                        }
                        else
                        {
                            Console.WriteLine("Parolu duzgun daxil edin! ");
                            value = Console.ReadLine();
                        }

                    }



                }
            }
        }
    }
}
