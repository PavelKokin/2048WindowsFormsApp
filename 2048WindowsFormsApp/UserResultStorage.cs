using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _2048WindowsFormsApp
{
    class UserResultStorage
    {
        public static void SaveUserResult(User user)
        {
            string path = "UserResult.txt";
            var userResultWriter = new StreamWriter(path, true, Encoding.UTF8);
            var formattedData = user.Name + "$" + user.Score;
            userResultWriter.WriteLine(formattedData);
            userResultWriter.Close();
        }
        public static List<User> GetUserResults()
        {
            var users = new List<User>();
            var userResultPath = "UserResult.txt";
            var fileinfo = new FileInfo(userResultPath);
            if (fileinfo.Exists)
            {
                var userResultReader = new StreamReader(userResultPath, Encoding.UTF8);
                var filedata = userResultReader.ReadToEnd();
                var lines = filedata.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var line in lines)
                {
                    var data = line.Split('$');
                    var user = new User(data[0]);
                    user.Score = Convert.ToInt32(data[1]);
                    users.Add(user);
                }
                userResultReader.Close();
            }
            return users;
        }
    }
}
