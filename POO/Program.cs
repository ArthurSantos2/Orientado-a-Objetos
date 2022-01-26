namespace Pagamentos
{
    class Program
    {
        //para chamar tem que ter a mesma assinatura, parametros iguais
        // static void RealizarPagamento(double valor)
        // {
        //     Console.WriteLine($"Pago o valor de {valor}");
        // }

        // static void TrocoDoPagamento(double valor)
        // {
        //     Console.WriteLine($"Valor pago de troco {valor}");
        // }
        
        

        static void Main(string[] args)
        {

            // var room = new Room(3);
            // room.RoomSoldOutEvent += OnRoomSoldOut;

            // room.ReserveSeat();
            // room.ReserveSeat();
            // room.ReserveSeat();
            // room.ReserveSeat();
            // room.ReserveSeat();


            // tipo de referência = objetos
            // => armazena os endereços, endereço dos dados
            // var pagamentoBoleto = new PagamentoBoleto();
            // pagamentoBoleto.Pagar();
            // pagamentoBoleto.Vencimento = DateTime.Now;
            // pagamentoBoleto.NumeroBoleto = "12346565";

            // var pagamento = new Pagamento();
            // pagamento.ToString();
            // var pagamento = new Pagamento(DateTime.Now);
            // // var pagamento = new PagamentoCartao();

            // pagamento.Pagar("15444");
            //usado com Idisposable para destruir um objeto depois de aberto
            // using(var pagamento = new Pagamento())
            // {
            //     Console.WriteLine("Processando pagamento");
            // }

            // Pagamento.Vencimento = DateTime.Now;

            // // var pagamento = new Pagamento();
            //  Console.WriteLine("Hello World!");
            //  //endereços na memoria não dá pra comparar pois sao diferentes, mesmo que pareçam iguais
            // var pessoaA = new Pessoa(1, "Arthuroturo");
            // var pessoaB = new Pessoa(1, "Arthuroturo");
            // //com a interface IEquatable pode ser feita a comparação dos objetos de modo que não compare o seu endereço como ocorre no ==
            // Console.WriteLine(pessoaA.Equals(pessoaB));


           
            // // downcast da classe filha para a base
            // var pessoa = new Pessoa();
            // var pessoaFisica = new PessoaFisica();
            // var pessoaJuridica = new PessoaJuridica();

            // pessoaFisica = (PessoaFisica)pessoa;

            // //upcast da classe pai para a filha
            // var pessoa = new Pessoa();
            // pessoa = new PessoaFisica();
            // pessoa = new PessoaJuridica();

            // var pagamento = new PagamentoBoleto();


            //delegates
            //o Pagar é uma funcção que chama outra função
            //delagate é um bruxaria. deve ter a função delegada com os mesmo parametros
            // var pagar = new Pagamento.Pagar(TrocoDoPagamento);
            // pagar(25);


            // var person = new Person();
            // var payment = new Payment();
            // var subscription = new Subscription();
            // var context = new DataContext<IPerson, Payment, Subscription>();
            // context.Save(person);
            // context.Save(payment);
            // context.Save(subscription);

            // //a lista é do tipo generica, tipos de lista abaixo
            // var payments = new IEnumerable<Payments>();
            // var paymants = new ICollection<Payment>();
            // var payments = new List<Payment>();
            //uma lista mais utilizada, com menos métodos
            // IEnumerable<Payment> payments = new List<Payment>();
            //mais completa e cheia de método o IList
            // var payments = new List<Payment>();
            // payments.Add(new Payment(1));
            // payments.Add(new Payment(2));
            // payments.Add(new Payment(3));
            // payments.Add(new Payment(4));
            // payments.Add(new Payment(5));
            IEnumerable<Payment> payments = new List<Payment>();

            payments.ToList();



            // foreach(var item in payments.Skip(2).Take(3))
            // {
            //     Console.WriteLine(item.Id);
            // }
            // //where traz um INumerable
            // var payment = payments.Where(x=>x.Id == 3);

            // //o first é diferente 
            // var paymentTwo = payments.First(x=>x.Id == 3);

            // Console.WriteLine(paymentTwo.Id);


            // payments.Remove(paymentTwo);
            // foreach(var iten in payments)
            // {
            //     Console.WriteLine(iten.Id);
            // }

            // var exists = payments.Skip(1);
            // Console.WriteLine(exists);

            // //lista dentro de outra utilizando ADDRANGE
            // var paidPayments = new List<Payment>();
            // paidPayments.AddRange(payments);
        }

        public class Payment
        {
            //abaixo uma propriedade, um PROP
            public int Id { get; set; }
            //abaixo um método construtor, eles são super necessários, um CTOR
            public Payment(int id)
            {
                Id = id;
            }

        }


        //gererics
        //Esse método abaixo seria usado para salvar no banco de dados. Essa é uma classe generica
        //where é para restringir. Uma boa pratica
        // public class DataContext<P, PA, S>
        //     where P : IPerson
        //     where PA : Payment
        //     where S : Subscription
        // {
        //     //aqui abaixo é um Método
        //     public void Save(P entity)
        //     {
                
        //     }

        //     public void Save(PA entity)
        //     {
                
        //     }

        //     public void Save(S entity)
        //     {
                
        //     }
        // }

        // public interface IPerson
        // {

        // }
        // public class Person : IPerson
        // {

        // }
        // public class Payment
        // {

        // }
        // public class Subscription
        // {

        // }
        // static void OnRoomSoldOut(object seats, EventArgs e)
        // {
        //     Console.WriteLine("Sala cheiona");
        // }

    }
    // public class Room
    //     {
    //         //aqui é um método construtor ctro
    //         public Room(int seats)
    //         {
    //             Seats = seats;
    //         }

    //         private int seatsInUse = 0;
    //         //aqui é uma propriedade PROP
    //         public int Seats { get; set; }

    //         public void ReserveSeat()
    //         {
    //             seatsInUse++;
    //             if(seatsInUse >= Seats)
    //             {
    //                 //evento fechado
    //                 OnRoomSoldOut(EventArgs.Empty);
    //             }
    //             else
    //             {
    //                 Console.WriteLine("Assento reservado moral");
    //             }
    //         }
    //         public event EventHandler RoomSoldOutEvent;

    //         protected virtual void OnRoomSoldOut(EventArgs e)
    //         {
    //             EventHandler handler = RoomSoldOutEvent;
    //             handler?.Invoke(this, e);
    //         }
    //     }

    // //isso é uma classe
    // public class Pagamento
    // {
    //     //delegate
    //     public delegate void Pagar(double valor);
    // }


    // a interface IEquatable serve para quando necessário comparar os objetos
    // public class Pessoa : IEquatable<Pessoa>
    // {

    //     public Pessoa(int id, string nome)
    //     {
    //         Nome = nome;
    //         Id = id;
    //     }        

    //     public int Id { get; set; }
    //     public string Nome { get; set; }

    //     public bool Equals(Pessoa pessoa)
    //     {
    //         return Id == pessoa.Id;
    //     }
    // }

    // public class PessoaFisica : Pessoa
    // {
    //     public string CPF { get; set; }
    // }
    
    // public class PessoaJuridica : Pessoa
    // {
    //     public string CNPJ {get; set;}
    // }
     


    //é positivo usar interfaces. A interface tem o que deve ser feito
    //Classes abstratas não pode ser instanciada, só pode ser herdada
    // public abstract class Pagamento : IPagamento
    // {
    //     public DateTime Vencimento { get; set; }

    //     public virtual void Pagar(double valor)
    //     {
    //         // Executar
    //     }
    // }

    // public class PagamentoCartaoCredito : Pagamento
    // {
    //      public override void Pagar(double valor)
    //     {
    //         base.Pagar(valor);
    //     }
    // }

    // public class PagamentoBoleto : Pagamento
    // {
    //      public override void Pagar(double valor)
    //     {
    //         base.Pagar(valor);
    //     }
    // }

    // public class PagamentoApplePay : Pagamento
    // {
    //      public override void Pagar(double valor)
    //     {
    //         base.Pagar(valor);
    //     }
    // }

    // // uma interface é como um contrato, ela não tem implementação
    // public interface IPagamento 
    // {
    //     DateTime Vencimento {get; set;}

    //     void Pagar(double valor);
    // }



    // SELEAD, usado quando a classe deva ter uma unica forma, nao gera herança
    // public sealed class Pagamento
    // {
    //     public static DateTime Vencimento { get; set;}
    // }
    // classe STATIC não pode ser instanciada 
    // se a classe é static, tudo dentro dela tem que ser static
    // static é sempre a mesma informação
    // public static class Pagamento
    // {
    //     public static DateTime Vencimento { get; set;}
    // }

    // public static class Settings
    // {
    //         public static string API_URL {get; set;}
    // }


    // public class Pagamento : IDisposable
    // {
    //     public Pagamento()
    //     {
    //         Console.WriteLine("Irá iniciar o pagamento");
    //     }

    //     public void Dispose()
    //     {
    //         Console.WriteLine("Finalizando o pagamento");
    //     }
    // }










    // modificadores de acesso: private, protected, internal e public

    // public class Pagamento
    // {
    //     public DateTime DataPagamento {get; set;}
    //     //método construtor 
    //     public Pagamento(DateTime vencimento)
    //     {
    //         Console.WriteLine("inciando o pagamento ");
    //         DataPagamento = DateTime.Now;
    //     }
    //     //Sobrecarga de metodo construtor = sem parametro(resolve questão de herança)
    //     public Pagamento() {}
    //     //virtual serve para sobrescrever quando em uma classe filha com override
    //     public virtual void Pagar(string numero){
    //         Console.WriteLine("Pagar");
    //     }

        // //sobrecarga de método
        // public void Pagar(string numero){}

        // public void Pagar(string numero, DateTime vencimento){}

        // public void Pagar(string numero, DateTime vencimento, bool pagarAposVencimento = false){}

        
        // Propriedades 

        // public int PropParaSOLID { get; private set; }

        // public DateTime Vencimento { get; set; }

        // private DateTime _dataPagamento;
        // public DateTime DataPagamento
        // {
        //     get { 
        //         Console.WriteLine("Lendo o valor");
        //         return _dataPagamento.AddDays(1); }
        //     set { 
        //         Console.WriteLine("Atribuindo valor");
        //         _dataPagamento = value; }
        // }
        
        
        // Address BillingAddress;

        // void Pagar(){}

        // Métodos
        // public virtual void Pagar(){}

        // public override string ToString()
        // {
        //     return Vencimento.ToString("dd, mm, yyyy");
        // }
        // // um private é apenas visivel dentro da classe

}

