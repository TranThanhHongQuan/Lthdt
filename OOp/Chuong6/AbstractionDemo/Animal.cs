using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public abstract class Animal
    {
        public string Name { get; set; }
        protected Animal(){}
        protected Animal(string Name){
            this.Name = Name;
        }

        public void Sleep(){
            System.Console.WriteLine("Animal like sleeping!!!");
        }
        // không thể định nghĩa thực vật eat
        // bỏ qua phần định nghĩa cho lớp con kế thừa tự định nghĩa
        // sử dụng trừu tượng
        public abstract void Eat();
    }
}