using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using DisneyShoppingCart.Models;


namespace DisneyShoppingCart.FileManager
{
    public class FileManagerClass
    {
        //private object newUsers;

        //private object newUsers;

        //public FileManagerClass()
        //{
        //}

        //public void CreateAFile(string path)
        //{
        //    bool fileExist = File.Exists(path);

        //    if (fileExist)
        //    {
        //        Console.WriteLine("File already exists");

        //        DateTime creationTime =
        //            File.GetCreationTime(path);

        //        Console.WriteLine("File was created on:"
        //                            + creationTime);

        //        DateTime modifiedTime =
        //            File.GetLastWriteTime(path);

        //        Console.WriteLine("File was modified on:"
        //                            + modifiedTime);
        //    }
        //    else
        //    {
        //        Console.WriteLine("You have created the file:"
        //                            + path);
        //        File.Create(path);
        //    }
        //}

        //public void MoveFile(string source, string destination)
        //{
        //    bool fileExist = File.Exists(source);

        //    if (fileExist)
        //    {
        //        File.Move(source, destination);
        //        Console.WriteLine("You have moved the file");
        //    }
        //    else
        //    {
        //        Console.WriteLine("File doesn't exist");
        //    }
        //}

        public void CreateDirectory(string path)
        {
            bool directoryExists = Directory.Exists(path);

            if (directoryExists)
            {
                Console.WriteLine("The directory already exists");

                DateTime creationTime =
                    Directory.GetCreationTime(path);
                Console.WriteLine("The directory was created on: "
                    + creationTime);

                DateTime modifiedTime =
                    Directory.GetLastWriteTime(path);
                Console.WriteLine("The directory was modified on: "
                    + modifiedTime);

            }
            else
            {
                Directory.CreateDirectory(path);
            }
        }



        public void MoveDirectory(string source, string destination)
        {
            bool directoryExists = Directory.Exists(source);

            if (directoryExists)
            {
                Directory.Move(source, destination);
                Console.WriteLine("You moved the directory");
            }
            else
            {
                Console.WriteLine("Directory does not exist");
            }
        }

        public void AddUsersToFile(string path,
                                    List<Users> userList)
        {
            Users newUser = new Users();
            newUser.Email = "myemail@somewhere.com";
            newUser.Password = "password";
            newUser.UserName = "Kat";

            Comments newComment = new Comments();
            newComment.TheComment = "This is the comment";

            path = "File1.txt";
            IFormatter formatter = new BinaryFormatter();


            FileStream newStream =
                new FileStream(path, FileMode.Create,
                                FileAccess.Write);

            formatter.Serialize(newStream, newUser);
            

            StreamWriter writer = new StreamWriter(newStream);
            writer.Write(newUser.UserName);
            writer.Write(newComment.TheComment);
            writer.Write("something");
            writer.Flush();
            newStream.Close();
        }
    }
}
