namespace AppPosicaoQuadrantePlano
{
    class Quadrante
    {
        private double x;
        private double y;

        public Quadrante(double X, double Y) 
        {
            this.x = X;
            this.y = Y;
        }

        public string VerificaQuatrante() 
        {
            string msg = "";

            if (x == 0 && y == 0)
            {
                msg="Ponto de origem!";
            }
            else if (x >= 0 && y >= 0)
            {
                msg= "1º Quadrante!";
            }
            else if (x<=0 && y>=0)
            {
                msg= "2º Quadrante!";
            }
            else if (x <= 0 && y <= 0)
            {
                msg= "3º Quadrante!";
            }
            else if (x >= 0 && y <= 0)
            {
                msg= "4º Quadrante!";
            }
            return msg;
        }
    }
}
