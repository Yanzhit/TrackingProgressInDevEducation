namespace TrackingProgressInDevEducationUI
{
    public static class Defines
    {
        public const string Email = "educationcoreteam@gmail.com";
        public const string From = "educationcoreteam@gmail.com";
        public const string VerifyRegistr = "Для окончания регистрации, укажите данный код:";
        public const string Password = "mqdyzcgsuhsltorr";
        public const string Host = "smtp.gmail.com";
        public const int Port = 587;
        public const string NewLine = "\n";
        public const string Sep = ", ";
        public const string ExeptionEx = "Отсутствует доступ к почте, возможно, не правильный пароль или нет разрешений на подключения";
        public const string ArgumentException = "Строка с адресом не должна быть пуста";
        public const string FormatException = "Неверный формат электронной почты. Почта должна иметь окончания - @gmail/yandex/mail/bk/list и другие";
        public const string Gap = " ";
        public const string Welcome = "Добро пожаловать в EducationCore";
        public const string Welcome2 = "Добро пожаловать";
        public const string Registration = "Добро пожаловать в EducationCore";
        public const string ExcepPasswordRepeat = "Пароли не совпадают, проверьте правильность введеных символов";
        public const string ExcepPasswordLength  = "Пароль не соответствует разрешенной длине";
        public const string ExcepFNameLength  = "ФИО не соответствует разрешенной длине";
        public const string ExcepEmailLength  = "Email не соответствует разрешенной длине";
        public const string Congratulation = "Поздравляем Вас с регистрацией!";
        public const string ExcepEntrance = "Не правильный логин либо пароль, повторите пожалуйста ввод, либо зарегистрируйтесь";
        public const string NoActive = "Этот аккаунт ещё не активирован, пожалуйства подтвердите свою почту. Выслать код повторно?";
        public const string Yes = "Нет";
        public const string No = "Отправить код";
        public const string Warning = "Оповещение";
        public const string Warning1 = "По соображениям безопасности, не активированным аккаунтам вход запрещен";
        public const string Warning2 = ", пожалуйста зарегистрируйтесь, либо пройдите активацию";
        public const string ErrorActive = "Если вам не удается активировать аккаунт, пожалуйста свяжитесь с нами";
        public const string ErrorActive1 = ", по электронной почте: ";
        public const string ErrorActive2 = "Мы с радостью поможем решить вашу проблему";
        public const string VerificationText = "Укажите проверочный код, отправленый на почту в окошно ниже";

        public const int EmailCharMin = 6;
        public const int EmailCharMax = 50;
        public const int PasswordCharMin = 3;
        public const int PasswordCharMax = 12;
        public const int FullNameCharMin = 6;
        public const int FullNameCharMax = 110;
        public const int LoginCharMin = 3;
        public const int LoginCharMax = 25;


        public const string AddStudentToGroupT = "Добавление нового студента";
        public const int AddStudentToGroupW = 400;
        public const int AddStudentToGroupH = 400;
        
        public const string NewCourseT = "Добавление нового курса";
        public const int NewCourseW = 850;
        public const int NewCourseH = 500;

        public const string NewGroupT = "Добавление новой группы";
        public const int NewGroupW = 50;
        public const int NewGroupH = 50;

        public const string NewTeamT = "Добавление новой команды";
        public const int NewTeamW = 750;
        public const int NewTeamH = 450;
        
        public const string StudentToTeamT = "Добавление новой команды";
        public const int StudentToTeamW = 400;
        public const int StudentToTeamH = 400;
    }
}