using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTransacciones.Models
{   [Table ("t_transaccion")]
    public class Transaccion
    {
        public enum Transaccion_TYPES{
            USD,
            BTC
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string? Remitente {get; set; }
        [Required]
        public string? Destinatario {get; set; }
        [Required]
        public string? Pais_origen {get; set; }
        [Required]
        public string? Destino {get; set; }
        [Required]
        public double? Monto {get; set; }  
        public double? Tasa_cambio {get; set; }
        public double? monto_final {get; set; }
        public string? Estado_Transaccion{get; set; }
        [Required]
        public required Transaccion_TYPES TipoMonto {get; set; } = Transaccion_TYPES.USD;

        public void CalcularMonto(){
            if (TipoMonto == 0){
                Tasa_cambio=0.00001556;
            } else {
                Tasa_cambio=60923.44;
            }
            monto_final=Monto*Tasa_cambio;
            Estado_Transaccion="Completado";
        }
    }
}