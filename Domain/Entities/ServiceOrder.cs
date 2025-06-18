using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;

public class ServiceOrder : BaseEntity
{
    public int Id { get; set; }
    public int Vehicles_Id { get; set; }
    public int TypeService_Id { get; set; }
    public int Client_Id { get; set; }
    public int State_Id { get; set; }
    public DateTime EntryDate { get; set; }
    public DateTime ExitDate { get; set; }
    public bool IsAuthorized { get; set; }
    public string? ClientMessage { get; set; }

    public State? State { get; set; }
    public TypeService? TypeService { get; set; }
    public Vehicle? Vehicle { get; set; }
    public Client? Client { get; set; }
    public ICollection<DetaillInventory> DetaillInventory { get; set; } = new HashSet<DetaillInventory>();
    public ICollection<OrderDetails> OrderDetails { get; set; } = new HashSet<OrderDetails>();
    
         
    }
