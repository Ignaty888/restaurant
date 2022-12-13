namespace Restaurant.Data
{
   public partial class Unit
    {
        /// 
        /// Переопределяем методы для правильного сравнения объектов данного типа
        /// Без переопределения в comboBox не будет выводиться текущее значение
        /// 

        public override bool Equals(object obj)
        {
            var val = obj as Unit;
            if (val != null)
            {
                return val.ID_Unit == ID_Unit;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return ID_Unit;
        }
    }
}
