using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Infrastructure.Utils
{
    public class NotificationConfig
    {
        public static string AdminErrorMessage = "Faild to update Entry, Please contact with administrator";
        public static string InsertSuccessMessage(string name)
        {
            return $"Successfully added {name}";
        }
        public static string InsertErrorMessage(string name)
        {
            return $"Could not added {name}, Maybe something wrong!";
        }
        public static string UpdateSuccessMessage(string name)
        {
            return $"Successfully updated {name}";
        }
        public static string UpdateErrorMessage(string name)
        {
            return $"Could not update {name}, Maybe something wrong!";
        }
        public static string DeleteSuccessMessage(string name)
        {
            return $"Successfully deleted {name}";
        }
        public static string DeleteErrorMessage(string name)
        {
            return $"Could not delete {name}, maybe something wrong";
        }

        public static string ExistMessage(string name)
        {
            return $"Already Exist! {name}";
        }

        public static string IncorrectPassword(string name)
        {
            return $"Invalid Old Password!";
        }
        public static string NotFoundError = "Invalid Entry. No Data Found!!";


        public static string InsertAccessMessage(string username, string name)
        {
            return $"{username}  Created {name}";
        }

        public static string NotFoundMessage(string name)
        {
            return $"{name}  not found!!";
        }

        public static string UpdateAccessMessage(string username, string name)
        {
            return $"{username} Modiified  {name}";
        }

        public static string DeleteAccessMessage(string username, string name)
        {
            return $"{username} Deleted  {name}";
        }

        public static string InvUpdateMessage(string username, string name)
        {
            return $"{username} Upadted Inventory";
        }

        public static string CustomAccessMessage(string username, string name, string message)
        {
            return $"{username} {message} {name}";
        }

        public static string ExceptionErrorMessage()
        {
            return "Something went worng!!";
        }

    }
}
