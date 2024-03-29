﻿namespace TrackingProgressInDevEducationDAL
{
    public static class Defines
    {
        /// <summary>
        /// Разделитель параметров в запросах, указывается в начале строки.
        /// </summary>
        public const string SepStr = "N'";
        /// <summary>
        /// Разделитель параметров в запросах, указывается между параметров
        /// </summary>
        public const string SepMid = "', N'";
        /// <summary>
        /// Разделитель параметров в запросах, указывается в конце строки.
        /// </summary>
        public const string SepEnd = "'";

        /// <summary>
        /// Ip адрес сервера базы данных
        /// </summary>
        public const string Ip = "80.78.240.16";

        /// <summary>
        /// 1 или True
        /// </summary>
        public const string Tr = "True";

        /// <summary>
        /// 0 или False
        /// </summary>
        public const string F = "False";

        /// <summary>
        /// Имя пользователя для подключения к удаленной базе данных
        /// </summary>
        public const string User = "DevEd";

        /// <summary>
        /// Пароль пользователя для подключения к удаленной базе данных
        /// </summary>
        public const string Password = "qqq!11";

        /// <summary>
        /// Каталог основной базы данных, для переключения на тестовую укажите DbTest
        /// </summary>
        public const string Db = "Sandbox";

        /// <summary>
        /// Каталог тестовой базы данных, для переключения на основную укажите Db
        /// </summary>
        public const string DbTest = "Sandbox.Test";

        /// <summary>
        /// Схема по умолчанию на сервере
        /// </summary>
        public const string Schema = "TrackingProgressInDevEducationDB";

        /// <summary>
        /// Тестовая схема на сервере
        /// </summary>
        public const string SchemaTest = "TrackingProgressInDevEducationDBTest";

        /// <summary>
        /// exec для запуска процедур
        /// </summary>
        public const string Exec = "exec";

        /// <summary>
        /// Точка
        /// </summary>
        public const string Point = ".";

        /// <summary>
        /// Отступ, пробел
        /// </summary>
        public const string Gap = " ";
    }
}