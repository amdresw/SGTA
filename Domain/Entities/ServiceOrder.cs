using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;

public class ServiceOrder
{
    public int Id { get; set; }
    public int Vehicles_Id { get; set; }
    public int TypeService_Id { get; set; }
    public int User_Id { get; set; }
    public int State_Id { get; set; }
    public date EntryDate { get; set; }
    public date ExitDate { get; set; }
    public bool IsAuthorized { get; set; }
    public text ClientMessage { get; set; }

    public State? State { get; set; }
    public TypeService? TypeService { get; set; }
    public ICollection<DetaillInventory> DetaillInventory { get; set; } = new HashSet<DetaillInventory>();
    public ICollection<OrderDetails> OrderDetails { get; set; } = new HashSet<OrderDetails>();
    
         
    }
