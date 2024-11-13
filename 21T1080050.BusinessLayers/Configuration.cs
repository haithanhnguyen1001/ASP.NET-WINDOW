﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV21T1080050.BusinessLayers
{
    public static class Configuration
    {
        private static string connectionString = "";
        /// <summary>
        /// Khởi tạo cấu hình cho BusinessLayer
        /// </summary>
        /// <param name="connectionString"></param>
        public static void Initialize(string connectionString)
        {
            Configuration.connectionString = connectionString;
        }
        /// <summary>
        /// Chuỗi tham số kết nối csdl
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                return connectionString;
            }
        }
    }
}
