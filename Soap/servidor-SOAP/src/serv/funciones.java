package serv;


public class funciones {
	public static void main(String args[]) {
        System.out.println(dv_rut("19844152"));
        System.out.println(separar_nombres("Valentina Ignacia Tobar Alarcon"));
        System.out.println(separar_apellidos("Valentina Ignacia Tobar Alarcon"));
        
    }
	public static String dv_rut (String Rut) {
		String resp = "Rut invalido";
		if(Rut.length() == 0) {
			return "Ingrese su Rut";
		}
		else if (Rut.length() > 8 || Rut.length() <= 6){
			return resp;
		}
		else{
			int rutlen = Rut.length();  
			int cont = 0;
			for(int i = 0; i < rutlen; i++) {
				char character = Rut.charAt(i);
				int ascii = (int) character;
				for (int j=48; j<=57; j++) {
					if(ascii == j) {
						cont++;
					}
				}
			}
			if(cont < Rut.length()) {
				return resp;
			}
			else{
				return digito_verificador(Rut);
				
			}
		}
	}
	public static String digito_verificador(String Rut){
		int len = Rut.length();
		char[] invertido = new char[len];
		for(int i=0; i<Rut.length() ; i++){
			char normal = Rut.charAt(len-1);
			invertido[i] = normal;
			len--;
		}
		int suma = 0, aux = 2;
		for (int j=0; j<invertido.length; j++){
			suma += Character.getNumericValue(invertido[j]) * aux;
			if(aux == 7) {
				aux = 1;
			}
			aux ++;
		}
		int resto = suma % 11, digito = 11 - resto;
		String dv = String.valueOf(digito);
		if(digito == 10) {
			dv = "k";
		}
		if (digito == 11) {
			dv = "0";
		}
		return Rut + "-" + dv;
	}
	public static String validar_nombre(String Nombre) {
		if(Nombre.length() == 0) {
			return "Ingrese un nombre";
		}
		else{
			int cont = 0;
			for(int i=0; i<Nombre.length(); i++) {
				char character = Nombre.charAt(i);
				int ascii = (int) character;
				if(ascii == 32) {
					cont++;
				}
				for(int j=65; j<=90; j++) {
					if(ascii == j) {
						cont++;
					}
				}
				for(int h=97; h<=122; h++) {
					if(ascii == h) {
						cont++;
					}
				}
			}
			if(cont == Nombre.length()) {
				return "Nombre valido";
			}
			else {
				return "Nombre invalido";
			}
				
		}
	}
	
	public static String separar_nombres(String Nombre) {
		String[] nombre_separado = Nombre.split(" ");
		String nombres = "";
		if(validar_nombre(Nombre)=="Nombre valido") {
			for(int i=0; i<=nombre_separado.length-3; i++){
				nombres+=nombre_separado[i] + " ";
			}
			return nombres;
		}
		else {

			return validar_nombre(Nombre);
		}
	}
	public static String separar_apellidos(String Nombre) {
		String[] nombre_separado = Nombre.split(" ");
		String apellidos = "";
		if(validar_nombre(Nombre)=="Nombre valido") {
			for(int i=2; i<nombre_separado.length; i++){
				apellidos+=nombre_separado[i] + " ";
			}
			return apellidos;
		}
		else {
			return validar_nombre(Nombre);
		}
	}
}


