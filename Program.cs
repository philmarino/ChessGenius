namespace ChessGenius1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Form1 form = new();
            Board board = new();
            board.Init();
            form.Draw(board); //this configures the view from the model
            Application.Run(form);
        }
    }
}