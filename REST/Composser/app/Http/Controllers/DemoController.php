<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class DemoController extends Controller
{
    public function rut (Request $request)
    {
        $nombre = $request->input('nombre');
        $RUT = $request->input('RUT');

        $resultado = "Hola, como estas $nombre $RUT";

        return json_encode(array(
            'status' => 200,
            'response' => array(
                'mensaje' => $resultado
            )
        ));




    } 
}
