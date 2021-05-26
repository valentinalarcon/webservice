<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class DemoController extends Controller
{

            public function rut(Request $request){
                $gets = $request->json()->all();
                $rut = $gets["rut"];
                $aux = $rut;
                $rut = intval($rut);
                $dv;
                if(strlen($aux)<7 or strlen($aux)>8){
                    return 500;
                }else{
                    $s=1;
                    for($m=0;$rut!=0;$rut/=10){
                        $s=($s+$rut%10*(9-$m++%6))%11;

                    }
                    $dv = chr($s?$s+47:75);
                    if ($dv=='K'){
                        return 100;
                    }
                    else{
                        return $dv;
                    }
                }

            }

            public function nombre(Request $request){
                
                $toma_n = $request->json()->all();
                $nombre = $toma_n["nombreC"];
                $auxn = $nombre;
                $arreglo_nombre = explode(" ",$auxn);
                $arreglojson = array();
                $arreglo_aux = array();
                $ct = count($arreglo_nombre);
                $arregloinv = array();
                $arregloinv[0] = 500;
                if($ct < 3){
                    return $arregloinv;
                }
                else{
                    if(preg_match("/^[a-zA-Z\s]*$/", $nombre)){
                        $arreglo_aux[0]=$arreglo_nombre[$ct-2];
                        $arreglo_aux[1]=$arreglo_nombre[$ct-1];
                        $arreglo_auxnombres = array();
                        for($i=0; $i<$ct-2 ; $i++){
                            array_push($arreglo_auxnombres,$arreglo_nombre[$i]);
                        }
                        array_push($arreglojson,$arreglo_auxnombres);
                        array_push($arreglojson,$arreglo_aux);
                        return $arreglojson;
                    }
                    else{
                        return $arregloinv;
                    }
                }
            }

       
}
