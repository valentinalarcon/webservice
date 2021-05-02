<?php 
    $var ="AXel Brito Gonzalez";

    function dv($r){
        $s=1;
        for($m=0;$r!=0;$r/=10)
            $s=($s+$r%10*(9-$m++%6))%11;
        echo 'El digito verificador es: ',chr($s?$s+47:75);
   }

    function valida_rut($rut){
        $aux = strval($rut);
        $resp = "Rut invalido";
        if(is_numeric($rut)){
            if(strlen($aux)<7 or strlen($aux)>8){
                echo $resp;
            }
            else{
                echo dv($rut);
            }
        }
        else{
            echo $resp;
        }
    }
    valida_rut("23-133842");
?>