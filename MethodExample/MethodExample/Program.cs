using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExample
{
 class MethodExample
 {
  int number;

  public void SomeMethod(int newValue)
  {
  this.number = newValue;
  }

 public void AnotherMethod()
 {
    Console.WriteLine(this.number);
 }

  //public int Add(int x)
  // {
  //  return x + this.number;
  // }
        public int Add(int x) => x + this.number;
        public void OptionalArgumentMethod(int x = 10, string y = "Hello")
        {
            Console.WriteLine($"{x} {y} {this.number}");
        }
public void ParamsMethod(string required, params string[] extras)
        {
            if (extras == null)
                throw new ArgumentNullException(nameof(extras));
            Console.WriteLine(required);
            foreach (var extra in extras)
                Console.WriteLine(extra);

        }
        static void Main()
        {
            var example = new MethodExample();
            example.OptionalArgumentMethod();
            example.OptionalArgumentMethod(12);
            example.OptionalArgumentMethod(y: "Goodbye");
            example.ParamsMethod("required","one","two");
            example.ParamsMethod("required");
            example.ParamsMethod("required", new string[] { "one", "two" });
            example.ParamsMethod("required");
            example.ParamsMethod("required", null);

        }


    }
}
