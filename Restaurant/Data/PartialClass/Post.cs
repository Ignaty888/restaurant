namespace Restaurant.Data
{
   public partial class Post
    {
        /// 
        /// Переопределяем методы для правильного сравнения объектов данного типа
        /// Без переопределения в comboBox не будет выводиться текущее значение
        /// 

        public override bool Equals(object obj)
        {
            var val = obj as Post;
            if (val != null)
            {
                return val.ID_post == ID_post;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return ID_post;
        }
    }
}
