namespace Restaurant.Data
{
   public partial class Ingredient
    {
        /// 
        /// Переопределяем методы для правильного сравнения объектов данного типа
        /// Без переопределения в comboBox не будет выводиться текущее значение
        /// 

        public override bool Equals(object obj)
        {
            var val = obj as Ingredient;
            if (val != null)
            {
                return val.ID_Ingredient == ID_Ingredient;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return ID_Ingredient;
        }
    }
}
