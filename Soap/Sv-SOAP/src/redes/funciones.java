package redes;

import org.apache.logging.log4j.Level;
import org.apache.logging.log4j.LogManager;
import org.apache.logging.log4j.Logger;
import org.apache.logging.log4j.core.config.Configurator;

public class funciones {
	
	static Logger log = LogManager.getLogger(funciones.class.getName());

	public static String VerificadorRut (String Rut) {
		String resp = "Rut invalido";
		if(Rut.length() == 0) {
			log.warn("Rut no Ingresado");
			log.error("Rut invalido");
			return "Ingrese su Rut";
		}
		else if (Rut.length() > 8 || Rut.length() <= 6){
			log.warn("Largo del Rut incorrecto | Largo: " + Rut.length());
			log.error("Rut invalido");
			return resp;
		}
		else{
			log.info("Ingresando Rut | Rut: " + Rut);
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
			log.info("Contador de caracteres | Cont: " + cont);
			if(cont < Rut.length()) {
				log.warn("El rut posee caracteres invalidos | Rut: " + Rut);
				log.info("Caracteres invalidos: " + (Rut.length() - cont));
				log.error("Rut invalido");
				return resp;
			}
			else{
				log.info("El Rut no posee caracteres invalidos | Rut: " + Rut);
				return DigitoVerificador(Rut);
			}
		}
	}
	public static String DigitoVerificador(String Rut){
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
		log.info("Digito verificador correspondiente al Rut ingresado | Dv: " + dv);
		return Rut + "-" + dv;
	}
	public  static boolean ValidarNombre(String Nombre) {
		if(Nombre.length() == 0) {
			log.warn("Nombre no Ingresado");
			log.error("Nombre invalido");
			return false;
		}
		else{
			log.warn("Analizando caracteres en el Nombre | Nombre: " + Nombre);
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
			log.info("Contador de caracteres | Cont: " + cont);
			if(cont == Nombre.length()) {
				log.info("El nombre no posee caracteres invalidos | Nombre: " + Nombre);

				return true;
			}
			else {
				log.warn("El nombre posee caracteres invalidos | Nombre " + Nombre);
				log.info("Caracteres invalidos: " + (Nombre.length() - cont));

				return false;
			}
				
		}
	}
	public static String SepararNombre(String Nombre) {
		String[] nombre_separado = Nombre.split(" ");
		String nombres = "Nombres:" + "\n";
		String apellidos = "Apellidos:" + "\n";
		if(ValidarNombre(Nombre)==true) {
				for(int i=0; i<nombre_separado.length-2; i++){
					nombres+=nombre_separado[i] + "\n";
				}
				for(int i=nombre_separado.length-2; i<nombre_separado.length; i++){
					apellidos+=nombre_separado[i] + "\n";
				}
			return nombres + "\n" + apellidos;
			
		}
		else {
			log.error("Nombre invalido");
			return "Nombre invalido";
		}
	}

}
