package Modelo;

abstract public class Cliente {

		protected String name;
		protected String cpf;
		protected String pedido;
		
		
		
		public Cliente(String name, String cpf, String pedido) {
			super();
			this.name = name;
			this.cpf = cpf;
			this.pedido = pedido;
			
			
		}
		public String getName() {
			return name;
		}
		public void setName(String name) {
			this.name = name;
		}
		public String getCpf() {
			return cpf;
		}
		public void setCpf(String cpf) {
			this.cpf = cpf;
		}
		public String getPedido() {
			return pedido;
		}
		public void setPedido(String pedido) {
			this.pedido = pedido;
		}

	
}
