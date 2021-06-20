namespace BlazorApp.Shared
{
    public static class FunctionUtil
    {
        public static int Fatorial(int numero)
        {
            if (numero <= 1)
                return 1;
            else return numero * Fatorial(numero - 1);
        }
    }
}
