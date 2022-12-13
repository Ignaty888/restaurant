namespace Restaurant.Data
{
   public partial class TypeDish
    {
       /// 
       /// Переопределяем методы для правильного сравнения объектов данного типа
       /// Без переопределения в comboBox не будет выводиться текущее значение
       /// 
       
        public override bool Equals(object obj)
        {
            var val = obj as TypeDish;
            if (val!=null)
            {
                return val.ID_TypeDish == ID_TypeDish;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return ID_TypeDish;
        }
    }
}
