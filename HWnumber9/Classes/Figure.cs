namespace HWnumber9.Classes
{
    internal class Figure
    {
        protected string colour;
        protected bool visibility;

        public Figure(string colour, bool visibility)
        {
            this.colour = colour;
            this.visibility = visibility;
        }
        #region Methods

        /// <summary>
        /// Метод для передвижения фигуры по горизонтали
        /// </summary>
        protected void MoveHorizontal()
        {

        }

        /// <summary>
        /// Метод для передвижения фигуры по вертикали
        /// </summary>
        protected void MoveVertically()
        {

        }

        /// <summary>
        /// Метод для изменения цвета фигуры
        /// </summary>
        protected void ChangeColour()
        {

        }

        /// <summary>
        /// Метод для опроса состояния фигуры
        /// </summary>
        protected void GetStatus()
        {

        }

        /// <summary>
        /// Метод для выведения информации о фигуре
        /// </summary>
        protected void GetInfo()
        {

        }
        #endregion
    }
}
