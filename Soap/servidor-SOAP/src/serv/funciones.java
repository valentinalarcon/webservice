package serv;
	
public class funciones {
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
	public  static boolean validar_nombre(String Nombre) {
		if(Nombre.length() == 0) {
			return false;
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
				return true;
			}
			else {
				return false;
			}
				
		}
	}
	public static String separar_nombre(String Nombre) {
		String[] nombre_separado = Nombre.split(" ");
		String nombre_final = "";
		String nombres = "Nombres:" + "\n";
		String apellidos = "Apellidos:" + "\n";
		if(validar_nombre(Nombre)==true) {
				for(int i=0; i<nombre_separado.length-2; i++){
					nombres+=nombre_separado[i] + "\n";
				}
				for(int i=nombre_separado.length-2; i<nombre_separado.length; i++){
					apellidos+=nombre_separado[i] + "\n";
				}
			return nombres + "\n" + apellidos;
			
		}
		else {
			return "Nombre invalido";
		}
	}
}


