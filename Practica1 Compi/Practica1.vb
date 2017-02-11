﻿'Generated by the GOLD Parser Builder

Option Explicit On
Option Strict Off

Imports System.IO
Imports System.Windows.Forms


Module MyParser
    Private Parser As New GOLD.Parser
    Dim opcion As Integer
    Dim tempF As Fondos
    Dim tempE As Enemigos
    Dim tempN As Naves
    Dim tempD As Defensas
    Dim Seleccion As Seleccion


    Private Enum SymbolIndex
        [Eof] = 0                                 ' (EOF)
        [Error] = 1                               ' (Error)
        [Comment] = 2                             ' Comment
        [Newline] = 3                             ' NewLine
        [Whitespace] = 4                          ' Whitespace
        [Timesdiv] = 5                            ' '*/'
        [Divtimes] = 6                            ' '/*'
        [Divdiv] = 7                              ' '//'
        [Minus] = 8                               ' '-'
        [Dollar] = 9                              ' '$'
        [Lparen] = 10                             ' '('
        [Rparen] = 11                             ' ')'
        [Times] = 12                              ' '*'
        [Comma] = 13                              ' ','
        [Div] = 14                                ' '/'
        [Lbracket] = 15                           ' '['
        [Rbracket] = 16                           ' ']'
        [Plus] = 17                               ' '+'
        [Eq] = 18                                 ' '='
        [Ataque] = 19                             ' ataque
        [Cadena] = 20                             ' Cadena
        [Defensas] = 21                           ' defensas
        [Enemigos] = 22                           ' enemigos
        [Entero] = 23                             ' Entero
        [Escenarios] = 24                         ' escenarios
        [Fin] = 25                                ' fin
        [Fondo] = 26                              ' fondo
        [Frecuencia] = 27                         ' frecuencia
        [Identificador] = 28                      ' identificador
        [Imagen_defensa] = 29                     ' 'imagen_defensa'
        [Imagen_disparo] = 30                     ' 'imagen_disparo'
        [Imagen_enemigo] = 31                     ' 'imagen_enemigo'
        [Imagen_nave] = 32                        ' 'imagen_nave'
        [Inicio] = 33                             ' Inicio
        [Naves] = 34                              ' naves
        [Nombre] = 35                             ' nombre
        [Proteccion] = 36                         ' proteccion
        [Punteo] = 37                             ' punteo
        [Ruta] = 38                               ' Ruta
        [Sonido] = 39                             ' sonido
        [Sonido_disparo] = 40                     ' 'sonido_disparo'
        [Velocidad] = 41                          ' velocidad
        [Vida] = 42                               ' vida
        [Ataque2] = 43                            ' <ataque>
        [Cdefensa] = 44                           ' <CDefensa>
        [Cenemigo] = 45                           ' <CEnemigo>
        [Cescenario] = 46                         ' <CEscenario>
        [Cidef] = 47                              ' <CIDEF>
        [Cienemi] = 48                            ' <CIENEMI>
        [Cierre] = 49                             ' <cierre>
        [Cies] = 50                               ' <CIES>
        [Cina] = 51                               ' <CINA>
        [Cnave] = 52                              ' <CNave>
        [Coma] = 53                               ' <coma>
        [Cuerpo] = 54                             ' <Cuerpo>
        [Cuerpodefensas] = 55                     ' <CuerpoDefensas>
        [Cuerpoescenarios] = 56                   ' <CuerpoEscenarios>
        [Cuerponaves] = 57                        ' <CuerpoNaves>
        [E] = 58                                  ' <E>
        [Enemigo] = 59                            ' <Enemigo>
        [Entero2] = 60                            ' <Entero>
        [Fin2] = 61                               ' <Fin>
        [Fondo2] = 62                             ' <fondo>
        [Frecuencia2] = 63                        ' <frecuencia>
        [Id] = 64                                 ' <ID>
        [Imagendef] = 65                          ' <imagenDef>
        [Imagendis] = 66                          ' <ImagenDis>
        [Imagene] = 67                            ' <ImagenE>
        [Imagenn] = 68                            ' <ImagenN>
        [Inicio2] = 69                            ' <Inicio>
        [Iniciodefensa] = 70                      ' <InicioDefensa>
        [Inicioenemigo] = 71                      ' <InicioEnemigo>
        [Inicioescenario] = 72                    ' <InicioEscenario>
        [Inicionave] = 73                         ' <InicioNave>
        [Mult] = 74                               ' <MULT>
        [Nombre2] = 75                            ' <nombre>
        [Proteccion2] = 76                        ' <Proteccion>
        [Punteo2] = 77                            ' <punteo>
        [Rataque] = 78                            ' <Rataque>
        [Rdefensa] = 79                           ' <RDefensa>
        [Renemigo] = 80                           ' <Renemigo>
        [Rescenario] = 81                         ' <REscenario>
        [Rfin] = 82                               ' <RFin>
        [Rfondo] = 83                             ' <RFondo>
        [Rfrecuencia] = 84                        ' <Rfrecuencia>
        [Rimagen_def] = 85                        ' <RImagen_Def>
        [Rimagen_dis] = 86                        ' <RImagen_Dis>
        [Rimagen_n] = 87                          ' <RImagen_N>
        [Rimagene] = 88                           ' <RImagenE>
        [Rinicio] = 89                            ' <RInicio>
        [Rnave] = 90                              ' <RNave>
        [Rnombre] = 91                            ' <Rnombre>
        [Rproteccion] = 92                        ' <RProteccion>
        [Rpunteo] = 93                            ' <Rpunteo>
        [Rsonido] = 94                            ' <RSonido>
        [Rsonido_dis] = 95                        ' <RSonido_Dis>
        [Ruta2] = 96                              ' <Ruta>
        [Rvelocidad] = 97                         ' <RVelocidad>
        [Rvida] = 98                              ' <RVida>
        [S] = 99                                  ' <S>
        [Sonido2] = 100                           ' <sonido>
        [Sonidodis] = 101                         ' <SonidoDis>
        [Valor] = 102                             ' <VALOR>
        [Velocidad2] = 103                        ' <velocidad>
        [Vida2] = 104                             ' <Vida>
    End Enum

    Private Enum ProductionIndex
        [S] = 0                                   ' <S> ::= <Inicio> <Cuerpo>
        [Inicio_Lbracket_Div_Rbracket] = 1        ' <Inicio> ::= '[' <RInicio> '/' <ID> ']'
        [Rinicio_Inicio] = 2                      ' <RInicio> ::= Inicio
        [Fin_Lbracket_Div_Rbracket] = 3           ' <Fin> ::= '[' <RFin> '/' <ID> ']'
        [Rfin_Fin] = 4                            ' <RFin> ::= fin
        [Cuerpo] = 5                              ' <Cuerpo> ::= <CuerpoEscenarios> <CuerpoNaves> <CuerpoDefensas> <Enemigo> <Fin>
        [Cuerpo2] = 6                             ' <Cuerpo> ::= <CuerpoEscenarios> <CuerpoNaves> <Enemigo> <CuerpoDefensas> <Fin>
        [Cuerpo3] = 7                             ' <Cuerpo> ::= <CuerpoEscenarios> <CuerpoDefensas> <CuerpoNaves> <Enemigo> <Fin>
        [Cuerpo4] = 8                             ' <Cuerpo> ::= <CuerpoEscenarios> <CuerpoDefensas> <Enemigo> <CuerpoNaves> <Fin>
        [Cuerpo5] = 9                             ' <Cuerpo> ::= <CuerpoEscenarios> <Enemigo> <CuerpoNaves> <CuerpoDefensas> <Fin>
        [Cuerpo6] = 10                            ' <Cuerpo> ::= <CuerpoEscenarios> <Enemigo> <CuerpoDefensas> <CuerpoNaves> <Fin>
        [Cuerpo7] = 11                            ' <Cuerpo> ::= <CuerpoNaves> <CuerpoEscenarios> <CuerpoDefensas> <Enemigo> <Fin>
        [Cuerpo8] = 12                            ' <Cuerpo> ::= <CuerpoNaves> <CuerpoEscenarios> <Enemigo> <CuerpoDefensas> <Fin>
        [Cuerpo9] = 13                            ' <Cuerpo> ::= <CuerpoNaves> <CuerpoDefensas> <CuerpoEscenarios> <Enemigo> <Fin>
        [Cuerpo10] = 14                           ' <Cuerpo> ::= <CuerpoNaves> <CuerpoDefensas> <Enemigo> <CuerpoEscenarios> <Fin>
        [Cuerpo11] = 15                           ' <Cuerpo> ::= <CuerpoNaves> <Enemigo> <CuerpoEscenarios> <CuerpoDefensas> <Fin>
        [Cuerpo12] = 16                           ' <Cuerpo> ::= <CuerpoNaves> <Enemigo> <CuerpoDefensas> <CuerpoEscenarios> <Fin>
        [Cuerpo13] = 17                           ' <Cuerpo> ::= <CuerpoDefensas> <CuerpoEscenarios> <CuerpoNaves> <Enemigo> <Fin>
        [Cuerpo14] = 18                           ' <Cuerpo> ::= <CuerpoDefensas> <CuerpoEscenarios> <Enemigo> <CuerpoNaves> <Fin>
        [Cuerpo15] = 19                           ' <Cuerpo> ::= <CuerpoDefensas> <CuerpoNaves> <CuerpoEscenarios> <Enemigo> <Fin>
        [Cuerpo16] = 20                           ' <Cuerpo> ::= <CuerpoDefensas> <CuerpoNaves> <Enemigo> <CuerpoEscenarios> <Fin>
        [Cuerpo17] = 21                           ' <Cuerpo> ::= <CuerpoDefensas> <Enemigo> <CuerpoEscenarios> <CuerpoNaves> <Fin>
        [Cuerpo18] = 22                           ' <Cuerpo> ::= <CuerpoDefensas> <Enemigo> <CuerpoNaves> <CuerpoEscenarios> <Fin>
        [Cuerpo19] = 23                           ' <Cuerpo> ::= <Enemigo> <CuerpoEscenarios> <CuerpoNaves> <CuerpoDefensas> <Fin>
        [Cuerpo20] = 24                           ' <Cuerpo> ::= <Enemigo> <CuerpoEscenarios> <CuerpoDefensas> <CuerpoNaves> <Fin>
        [Cuerpo21] = 25                           ' <Cuerpo> ::= <Enemigo> <CuerpoNaves> <CuerpoEscenarios> <CuerpoDefensas> <Fin>
        [Cuerpo22] = 26                           ' <Cuerpo> ::= <Enemigo> <CuerpoNaves> <CuerpoDefensas> <CuerpoEscenarios> <Fin>
        [Cuerpo23] = 27                           ' <Cuerpo> ::= <Enemigo> <CuerpoDefensas> <CuerpoEscenarios> <CuerpoNaves> <Fin>
        [Cuerpo24] = 28                           ' <Cuerpo> ::= <Enemigo> <CuerpoDefensas> <CuerpoNaves> <CuerpoEscenarios>
        [Cuerpoescenarios] = 29                   ' <CuerpoEscenarios> ::= <CuerpoEscenarios> <CEscenario>
        [Cuerpoescenarios2] = 30                  ' <CuerpoEscenarios> ::= <CEscenario>
        [Cescenario] = 31                         ' <CEscenario> ::= <InicioEscenario> <CIES>
        [Cies] = 32                               ' <CIES> ::= <fondo> <coma> <CIES>
        [Cies2] = 33                              ' <CIES> ::= <sonido> <coma> <CIES>
        [Cies3] = 34                              ' <CIES> ::= <fondo> <cierre>
        [Cies4] = 35                              ' <CIES> ::= <sonido> <cierre>
        [Inicioescenario_Lbracket_Div_Rbracket] = 36 ' <InicioEscenario> ::= '[' <REscenario> '/' <ID> ']'
        [Fondo_Eq] = 37                           ' <fondo> ::= <RFondo> '=' <Ruta>
        [Sonido_Eq] = 38                          ' <sonido> ::= <RSonido> '=' <Ruta>
        [Cuerponaves] = 39                        ' <CuerpoNaves> ::= <CuerpoNaves> <CNave>
        [Cuerponaves2] = 40                       ' <CuerpoNaves> ::= <CNave>
        [Cnave] = 41                              ' <CNave> ::= <InicioNave> <CINA>
        [Cina] = 42                               ' <CINA> ::= <ImagenN> <coma> <CINA>
        [Cina2] = 43                              ' <CINA> ::= <ImagenDis> <coma> <CINA>
        [Cina3] = 44                              ' <CINA> ::= <SonidoDis> <coma> <CINA>
        [Cina4] = 45                              ' <CINA> ::= <Vida> <coma> <CINA>
        [Cina5] = 46                              ' <CINA> ::= <ataque> <coma> <CINA>
        [Cina6] = 47                              ' <CINA> ::= <ImagenN> <cierre>
        [Cina7] = 48                              ' <CINA> ::= <ImagenDis> <cierre>
        [Cina8] = 49                              ' <CINA> ::= <SonidoDis> <cierre>
        [Cina9] = 50                              ' <CINA> ::= <Vida> <cierre>
        [Cina10] = 51                             ' <CINA> ::= <ataque> <cierre>
        [Inicionave_Lbracket_Div_Rbracket] = 52   ' <InicioNave> ::= '[' <RNave> '/' <ID> ']'
        [Imagenn_Eq] = 53                         ' <ImagenN> ::= <RImagen_N> '=' <Ruta>
        [Imagendis_Eq] = 54                       ' <ImagenDis> ::= <RImagen_Dis> '=' <Ruta>
        [Sonidodis_Eq] = 55                       ' <SonidoDis> ::= <RSonido_Dis> '=' <Ruta>
        [Vida_Eq] = 56                            ' <Vida> ::= <RVida> '=' <Entero>
        [Ataque_Eq] = 57                          ' <ataque> ::= <Rataque> '=' <Entero>
        [Cuerpodefensas] = 58                     ' <CuerpoDefensas> ::= <CuerpoDefensas> <CDefensa>
        [Cuerpodefensas2] = 59                    ' <CuerpoDefensas> ::= <CDefensa>
        [Cdefensa] = 60                           ' <CDefensa> ::= <InicioDefensa> <CIDEF>
        [Cidef] = 61                              ' <CIDEF> ::= <imagenDef> <coma> <CIDEF>
        [Cidef2] = 62                             ' <CIDEF> ::= <Proteccion> <coma> <CIDEF>
        [Cidef3] = 63                             ' <CIDEF> ::= <imagenDef> <cierre>
        [Cidef4] = 64                             ' <CIDEF> ::= <Proteccion> <cierre>
        [Iniciodefensa_Lbracket_Div_Rbracket] = 65 ' <InicioDefensa> ::= '[' <RDefensa> '/' <ID> ']'
        [Imagendef_Eq] = 66                       ' <imagenDef> ::= <RImagen_Def> '=' <Ruta>
        [Proteccion_Eq] = 67                      ' <Proteccion> ::= <RProteccion> '=' <Entero>
        [Enemigo] = 68                            ' <Enemigo> ::= <Enemigo> <CEnemigo>
        [Enemigo2] = 69                           ' <Enemigo> ::= <CEnemigo>
        [Cenemigo] = 70                           ' <CEnemigo> ::= <InicioEnemigo> <CIENEMI>
        [Cienemi] = 71                            ' <CIENEMI> ::= <nombre> <coma> <CIENEMI>
        [Cienemi2] = 72                           ' <CIENEMI> ::= <ImagenE> <coma> <CIENEMI>
        [Cienemi3] = 73                           ' <CIENEMI> ::= <ImagenDis> <coma> <CIENEMI>
        [Cienemi4] = 74                           ' <CIENEMI> ::= <SonidoDis> <coma> <CIENEMI>
        [Cienemi5] = 75                           ' <CIENEMI> ::= <Vida> <coma> <CIENEMI>
        [Cienemi6] = 76                           ' <CIENEMI> ::= <ataque> <coma> <CIENEMI>
        [Cienemi7] = 77                           ' <CIENEMI> ::= <frecuencia> <coma> <CIENEMI>
        [Cienemi8] = 78                           ' <CIENEMI> ::= <velocidad> <coma> <CIENEMI>
        [Cienemi9] = 79                           ' <CIENEMI> ::= <punteo> <coma> <CIENEMI>
        [Cienemi10] = 80                          ' <CIENEMI> ::= <nombre> <cierre>
        [Cienemi11] = 81                          ' <CIENEMI> ::= <ImagenE> <cierre>
        [Cienemi12] = 82                          ' <CIENEMI> ::= <ImagenDis> <cierre>
        [Cienemi13] = 83                          ' <CIENEMI> ::= <SonidoDis> <cierre>
        [Cienemi14] = 84                          ' <CIENEMI> ::= <Vida> <cierre>
        [Cienemi15] = 85                          ' <CIENEMI> ::= <ataque> <cierre>
        [Cienemi16] = 86                          ' <CIENEMI> ::= <frecuencia> <cierre>
        [Cienemi17] = 87                          ' <CIENEMI> ::= <velocidad> <cierre>
        [Cienemi18] = 88                          ' <CIENEMI> ::= <punteo> <cierre>
        [Inicioenemigo_Lbracket_Div_Rbracket] = 89 ' <InicioEnemigo> ::= '[' <Renemigo> '/' <ID> ']'
        [Nombre_Eq_Cadena] = 90                   ' <nombre> ::= <Rnombre> '=' Cadena
        [Imagene_Eq] = 91                         ' <ImagenE> ::= <RImagenE> '=' <Ruta>
        [Frecuencia_Eq] = 92                      ' <frecuencia> ::= <Rfrecuencia> '=' <E>
        [Velocidad_Eq] = 93                       ' <velocidad> ::= <RVelocidad> '=' <E>
        [Punteo_Eq] = 94                          ' <punteo> ::= <Rpunteo> '=' <E>
        [Id_Identificador] = 95                   ' <ID> ::= identificador
        [Coma_Comma] = 96                         ' <coma> ::= ','
        [Cierre_Dollar] = 97                      ' <cierre> ::= '$'
        [Ruta_Ruta] = 98                          ' <Ruta> ::= Ruta
        [Rdefensa_Defensas] = 99                  ' <RDefensa> ::= defensas
        [Rescenario_Escenarios] = 100             ' <REscenario> ::= escenarios
        [Rfondo_Fondo] = 101                      ' <RFondo> ::= fondo
        [Rimagene_Imagen_enemigo] = 102           ' <RImagenE> ::= 'imagen_enemigo'
        [Rimagen_def_Imagen_defensa] = 103        ' <RImagen_Def> ::= 'imagen_defensa'
        [Rimagen_dis_Imagen_disparo] = 104        ' <RImagen_Dis> ::= 'imagen_disparo'
        [Rimagen_n_Imagen_nave] = 105             ' <RImagen_N> ::= 'imagen_nave'
        [Rnave_Naves] = 106                       ' <RNave> ::= naves
        [Rsonido_Sonido] = 107                    ' <RSonido> ::= sonido
        [Rsonido_dis_Sonido_disparo] = 108        ' <RSonido_Dis> ::= 'sonido_disparo'
        [Rvida_Vida] = 109                        ' <RVida> ::= vida
        [Rataque_Ataque] = 110                    ' <Rataque> ::= ataque
        [Rproteccion_Proteccion] = 111            ' <RProteccion> ::= proteccion
        [Renemigo_Enemigos] = 112                 ' <Renemigo> ::= enemigos
        [Rnombre_Nombre] = 113                    ' <Rnombre> ::= nombre
        [Rfrecuencia_Frecuencia] = 114            ' <Rfrecuencia> ::= frecuencia
        [Rvelocidad_Velocidad] = 115              ' <RVelocidad> ::= velocidad
        [Rpunteo_Punteo] = 116                    ' <Rpunteo> ::= punteo
        [Entero_Entero] = 117                     ' <Entero> ::= Entero
        [E_Plus] = 118                            ' <E> ::= <E> '+' <MULT>
        [E_Minus] = 119                           ' <E> ::= <E> '-' <MULT>
        [E] = 120                                 ' <E> ::= <MULT>
        [Mult_Times] = 121                        ' <MULT> ::= <MULT> '*' <VALOR>
        [Mult_Div] = 122                          ' <MULT> ::= <MULT> '/' <VALOR>
        [Mult] = 123                              ' <MULT> ::= <VALOR>
        [Valor] = 124                             ' <VALOR> ::= <Entero>
        [Valor_Lparen_Rparen] = 125               ' <VALOR> ::= '(' <E> ')'
    End Enum

    Public Program As Object     'You might derive a specific object

    Public Sub Setup()
        'This procedure can be called to load the parse tables. The class can
        'read tables using a BinaryReader.

        Parser.LoadTables(Path.Combine(Application.StartupPath, "Practica1.egt"))
    End Sub
    
    Public Function Parse(ByVal Reader As TextReader) As Boolean
        'This procedure starts the GOLD Parser Engine and handles each of the
        'messages it returns. Each time a reduction is made, you can create new
        'custom object and reassign the .CurrentReduction property. Otherwise, 
        'the system will use the Reduction object that was returned.
        '
        'The resulting tree will be a pure representation of the language 
        'and will be ready to implement.

        Dim Response As GOLD.ParseMessage
        Dim Done as Boolean                  'Controls when we leave the loop
        Dim Accepted As Boolean = False      'Was the parse successful?

        Accepted = False    'Unless the program is accepted by the parser

        Parser.Open(Reader)
        Parser.TrimReductions = False  'Please read about this feature before enabling  

        Done = False
        Do Until Done
            Response = Parser.Parse()

            Select Case Response
                Case GOLD.ParseMessage.LexicalError
                    'Cannot recognize token
                    Done = True

                Case GOLD.ParseMessage.SyntaxError
                    'Expecting a different token
                    Done = True

                Case GOLD.ParseMessage.Reduction
                    'Create a customized object to store the reduction
                    Parser.CurrentReduction = CreateNewObject(Parser.CurrentReduction)

                Case GOLD.ParseMessage.Accept
                    'Accepted!
                    'Program = Parser.CurrentReduction  'The root node!                 
                    Done = True
                    Accepted = True

                Case GOLD.ParseMessage.TokenRead
                    'You don't have to do anything here.

                Case GOLD.ParseMessage.InternalError
                    'INTERNAL ERROR! Something is horribly wrong.
                    Done = True

                Case GOLD.ParseMessage.NotLoadedError
                    'This error occurs if the CGT was not loaded.                   
                    Done = True

                Case GOLD.ParseMessage.GroupError
                    'COMMENT ERROR! Unexpected end of file
                    Done = True
            End Select
        Loop
        Dim Seleccion As New Seleccion
        Seleccion.Label1.Text = Nombre_Juego
        Seleccion.Show()

        Return Accepted
    End Function

    Private Function CreateNewObject(Reduction as GOLD.Reduction) As Object
        Dim Result As Object = Nothing

        With Reduction
            Select Case .Parent.TableIndex
                Case ProductionIndex.S
                    ' <S> ::= <Inicio> <Cuerpo> 

                Case ProductionIndex.Inicio_Lbracket_Div_Rbracket
                    ' <Inicio> ::= '[' <RInicio> '/' <ID> ']' 

                Case ProductionIndex.Rinicio_Inicio
                    ' <RInicio> ::= Inicio 

                Case ProductionIndex.Fin_Lbracket_Div_Rbracket
                    ' <Fin> ::= '[' <RFin> '/' <ID> ']' 

                Case ProductionIndex.Rfin_Fin
                    ' <RFin> ::= fin 

                Case ProductionIndex.Cuerpo
                    ' <Cuerpo> ::= <CuerpoEscenarios> <CuerpoNaves> <CuerpoDefensas> <Enemigo> <Fin> 

                Case ProductionIndex.Cuerpo2
                    ' <Cuerpo> ::= <CuerpoEscenarios> <CuerpoNaves> <Enemigo> <CuerpoDefensas> <Fin> 

                Case ProductionIndex.Cuerpo3
                    ' <Cuerpo> ::= <CuerpoEscenarios> <CuerpoDefensas> <CuerpoNaves> <Enemigo> <Fin> 

                Case ProductionIndex.Cuerpo4
                    ' <Cuerpo> ::= <CuerpoEscenarios> <CuerpoDefensas> <Enemigo> <CuerpoNaves> <Fin> 

                Case ProductionIndex.Cuerpo5
                    ' <Cuerpo> ::= <CuerpoEscenarios> <Enemigo> <CuerpoNaves> <CuerpoDefensas> <Fin> 

                Case ProductionIndex.Cuerpo6
                    ' <Cuerpo> ::= <CuerpoEscenarios> <Enemigo> <CuerpoDefensas> <CuerpoNaves> <Fin> 

                Case ProductionIndex.Cuerpo7
                    ' <Cuerpo> ::= <CuerpoNaves> <CuerpoEscenarios> <CuerpoDefensas> <Enemigo> <Fin> 

                Case ProductionIndex.Cuerpo8
                    ' <Cuerpo> ::= <CuerpoNaves> <CuerpoEscenarios> <Enemigo> <CuerpoDefensas> <Fin> 

                Case ProductionIndex.Cuerpo9
                    ' <Cuerpo> ::= <CuerpoNaves> <CuerpoDefensas> <CuerpoEscenarios> <Enemigo> <Fin> 

                Case ProductionIndex.Cuerpo10
                    ' <Cuerpo> ::= <CuerpoNaves> <CuerpoDefensas> <Enemigo> <CuerpoEscenarios> <Fin> 

                Case ProductionIndex.Cuerpo11
                    ' <Cuerpo> ::= <CuerpoNaves> <Enemigo> <CuerpoEscenarios> <CuerpoDefensas> <Fin> 

                Case ProductionIndex.Cuerpo12
                    ' <Cuerpo> ::= <CuerpoNaves> <Enemigo> <CuerpoDefensas> <CuerpoEscenarios> <Fin> 

                Case ProductionIndex.Cuerpo13
                    ' <Cuerpo> ::= <CuerpoDefensas> <CuerpoEscenarios> <CuerpoNaves> <Enemigo> <Fin> 

                Case ProductionIndex.Cuerpo14
                    ' <Cuerpo> ::= <CuerpoDefensas> <CuerpoEscenarios> <Enemigo> <CuerpoNaves> <Fin> 

                Case ProductionIndex.Cuerpo15
                    ' <Cuerpo> ::= <CuerpoDefensas> <CuerpoNaves> <CuerpoEscenarios> <Enemigo> <Fin> 

                Case ProductionIndex.Cuerpo16
                    ' <Cuerpo> ::= <CuerpoDefensas> <CuerpoNaves> <Enemigo> <CuerpoEscenarios> <Fin> 

                Case ProductionIndex.Cuerpo17
                    ' <Cuerpo> ::= <CuerpoDefensas> <Enemigo> <CuerpoEscenarios> <CuerpoNaves> <Fin> 

                Case ProductionIndex.Cuerpo18
                    ' <Cuerpo> ::= <CuerpoDefensas> <Enemigo> <CuerpoNaves> <CuerpoEscenarios> <Fin> 

                Case ProductionIndex.Cuerpo19
                    ' <Cuerpo> ::= <Enemigo> <CuerpoEscenarios> <CuerpoNaves> <CuerpoDefensas> <Fin> 

                Case ProductionIndex.Cuerpo20
                    ' <Cuerpo> ::= <Enemigo> <CuerpoEscenarios> <CuerpoDefensas> <CuerpoNaves> <Fin> 

                Case ProductionIndex.Cuerpo21
                    ' <Cuerpo> ::= <Enemigo> <CuerpoNaves> <CuerpoEscenarios> <CuerpoDefensas> <Fin> 

                Case ProductionIndex.Cuerpo22
                    ' <Cuerpo> ::= <Enemigo> <CuerpoNaves> <CuerpoDefensas> <CuerpoEscenarios> <Fin> 

                Case ProductionIndex.Cuerpo23
                    ' <Cuerpo> ::= <Enemigo> <CuerpoDefensas> <CuerpoEscenarios> <CuerpoNaves> <Fin> 

                Case ProductionIndex.Cuerpo24
                    ' <Cuerpo> ::= <Enemigo> <CuerpoDefensas> <CuerpoNaves> <CuerpoEscenarios> 

                Case ProductionIndex.Cuerpoescenarios
                    ' <CuerpoEscenarios> ::= <CuerpoEscenarios> <CEscenario> 

                Case ProductionIndex.Cuerpoescenarios2
                    ' <CuerpoEscenarios> ::= <CEscenario> 

                Case ProductionIndex.Cescenario
                    ' <CEscenario> ::= <InicioEscenario> <CIES> 

                Case ProductionIndex.Cies
                    ' <CIES> ::= <fondo> <coma> <CIES> 

                Case ProductionIndex.Cies2
                    ' <CIES> ::= <sonido> <coma> <CIES> 

                Case ProductionIndex.Cies3
                    ' <CIES> ::= <fondo> <cierre> 

                Case ProductionIndex.Cies4
                    ' <CIES> ::= <sonido> <cierre> 

                Case ProductionIndex.Inicioescenario_Lbracket_Div_Rbracket
                    ' <InicioEscenario> ::= '[' <REscenario> '/' <ID> ']' 

                Case ProductionIndex.Fondo_Eq
                    ' <fondo> ::= <RFondo> '=' <Ruta> 

                Case ProductionIndex.Sonido_Eq
                    ' <sonido> ::= <RSonido> '=' <Ruta> 

                Case ProductionIndex.Cuerponaves
                    ' <CuerpoNaves> ::= <CuerpoNaves> <CNave> 

                Case ProductionIndex.Cuerponaves2
                    ' <CuerpoNaves> ::= <CNave> 

                Case ProductionIndex.Cnave
                    ' <CNave> ::= <InicioNave> <CINA> 

                Case ProductionIndex.Cina
                    ' <CINA> ::= <ImagenN> <coma> <CINA> 

                Case ProductionIndex.Cina2
                    ' <CINA> ::= <ImagenDis> <coma> <CINA> 

                Case ProductionIndex.Cina3
                    ' <CINA> ::= <SonidoDis> <coma> <CINA> 

                Case ProductionIndex.Cina4
                    ' <CINA> ::= <Vida> <coma> <CINA> 

                Case ProductionIndex.Cina5
                    ' <CINA> ::= <ataque> <coma> <CINA> 

                Case ProductionIndex.Cina6
                    ' <CINA> ::= <ImagenN> <cierre> 

                Case ProductionIndex.Cina7
                    ' <CINA> ::= <ImagenDis> <cierre> 

                Case ProductionIndex.Cina8
                    ' <CINA> ::= <SonidoDis> <cierre> 

                Case ProductionIndex.Cina9
                    ' <CINA> ::= <Vida> <cierre> 

                Case ProductionIndex.Cina10
                    ' <CINA> ::= <ataque> <cierre> 

                Case ProductionIndex.Inicionave_Lbracket_Div_Rbracket
                    ' <InicioNave> ::= '[' <RNave> '/' <ID> ']' 

                Case ProductionIndex.Imagenn_Eq
                    ' <ImagenN> ::= <RImagen_N> '=' <Ruta> 

                Case ProductionIndex.Imagendis_Eq
                    ' <ImagenDis> ::= <RImagen_Dis> '=' <Ruta> 

                Case ProductionIndex.Sonidodis_Eq
                    ' <SonidoDis> ::= <RSonido_Dis> '=' <Ruta> 

                Case ProductionIndex.Vida_Eq
                    ' <Vida> ::= <RVida> '=' <Entero> 

                Case ProductionIndex.Ataque_Eq
                    ' <ataque> ::= <Rataque> '=' <Entero> 

                Case ProductionIndex.Cuerpodefensas
                    ' <CuerpoDefensas> ::= <CuerpoDefensas> <CDefensa> 

                Case ProductionIndex.Cuerpodefensas2
                    ' <CuerpoDefensas> ::= <CDefensa> 

                Case ProductionIndex.Cdefensa
                    ' <CDefensa> ::= <InicioDefensa> <CIDEF> 

                Case ProductionIndex.Cidef
                    ' <CIDEF> ::= <imagenDef> <coma> <CIDEF> 

                Case ProductionIndex.Cidef2
                    ' <CIDEF> ::= <Proteccion> <coma> <CIDEF> 

                Case ProductionIndex.Cidef3
                    ' <CIDEF> ::= <imagenDef> <cierre> 

                Case ProductionIndex.Cidef4
                    ' <CIDEF> ::= <Proteccion> <cierre> 

                Case ProductionIndex.Iniciodefensa_Lbracket_Div_Rbracket
                    ' <InicioDefensa> ::= '[' <RDefensa> '/' <ID> ']' 

                Case ProductionIndex.Imagendef_Eq
                    ' <imagenDef> ::= <RImagen_Def> '=' <Ruta> 

                Case ProductionIndex.Proteccion_Eq
                    ' <Proteccion> ::= <RProteccion> '=' <Entero> 

                Case ProductionIndex.Enemigo
                    ' <Enemigo> ::= <Enemigo> <CEnemigo> 

                Case ProductionIndex.Enemigo2
                    ' <Enemigo> ::= <CEnemigo> 

                Case ProductionIndex.Cenemigo
                    ' <CEnemigo> ::= <InicioEnemigo> <CIENEMI> 

                Case ProductionIndex.Cienemi
                    ' <CIENEMI> ::= <nombre> <coma> <CIENEMI> 

                Case ProductionIndex.Cienemi2
                    ' <CIENEMI> ::= <ImagenE> <coma> <CIENEMI> 

                Case ProductionIndex.Cienemi3
                    ' <CIENEMI> ::= <ImagenDis> <coma> <CIENEMI> 

                Case ProductionIndex.Cienemi4
                    ' <CIENEMI> ::= <SonidoDis> <coma> <CIENEMI> 

                Case ProductionIndex.Cienemi5
                    ' <CIENEMI> ::= <Vida> <coma> <CIENEMI> 

                Case ProductionIndex.Cienemi6
                    ' <CIENEMI> ::= <ataque> <coma> <CIENEMI> 

                Case ProductionIndex.Cienemi7
                    ' <CIENEMI> ::= <frecuencia> <coma> <CIENEMI> 

                Case ProductionIndex.Cienemi8
                    ' <CIENEMI> ::= <velocidad> <coma> <CIENEMI> 

                Case ProductionIndex.Cienemi9
                    ' <CIENEMI> ::= <punteo> <coma> <CIENEMI> 

                Case ProductionIndex.Cienemi10
                    ' <CIENEMI> ::= <nombre> <cierre> 

                Case ProductionIndex.Cienemi11
                    ' <CIENEMI> ::= <ImagenE> <cierre> 

                Case ProductionIndex.Cienemi12
                    ' <CIENEMI> ::= <ImagenDis> <cierre> 

                Case ProductionIndex.Cienemi13
                    ' <CIENEMI> ::= <SonidoDis> <cierre> 

                Case ProductionIndex.Cienemi14
                    ' <CIENEMI> ::= <Vida> <cierre> 

                Case ProductionIndex.Cienemi15
                    ' <CIENEMI> ::= <ataque> <cierre> 

                Case ProductionIndex.Cienemi16
                    ' <CIENEMI> ::= <frecuencia> <cierre> 

                Case ProductionIndex.Cienemi17
                    ' <CIENEMI> ::= <velocidad> <cierre> 

                Case ProductionIndex.Cienemi18
                    ' <CIENEMI> ::= <punteo> <cierre> 

                Case ProductionIndex.Inicioenemigo_Lbracket_Div_Rbracket
                    ' <InicioEnemigo> ::= '[' <Renemigo> '/' <ID> ']' 

                Case ProductionIndex.Nombre_Eq_Cadena
                    ' <nombre> ::= <Rnombre> '=' Cadena 

                Case ProductionIndex.Imagene_Eq
                    ' <ImagenE> ::= <RImagenE> '=' <Ruta> 

                Case ProductionIndex.Frecuencia_Eq
                    ' <frecuencia> ::= <Rfrecuencia> '=' <E> 

                Case ProductionIndex.Velocidad_Eq
                    ' <velocidad> ::= <RVelocidad> '=' <E> 

                Case ProductionIndex.Punteo_Eq
                    ' <punteo> ::= <Rpunteo> '=' <E> 

                Case ProductionIndex.Id_Identificador
                    If (opcion = 1) Then
                        Nombre_Juego = Reduction.Item(0).Data
                    ElseIf (opcion = 2 Or opcion = 3) Then
                        tempF.Nombre = Reduction.Item(0).Data

                    ElseIf (opcion = 5) Then
                        tempN.Nombre = Reduction.Item(0).Data

                    ElseIf (opcion = 11) Then
                        tempD.Nombre = Reduction.Item(0).Data

                    End If
                    ' <ID> ::= identificador 

                Case ProductionIndex.Coma_Comma
                    ' <coma> ::= ',' 

                Case ProductionIndex.Cierre_Dollar
                    If (opcion = 3 Or opcion = 4 Or opcion = 2) Then
                        LFondos.Insertar(tempF)
                    ElseIf (opcion = 5 Or opcion = 6 Or opcion = 7 Or opcion = 8 Or opcion = 9 Or opcion = 10) Then
                        LNaves.Insertar(tempN)
                    ElseIf (opcion = 11 Or opcion = 12 Or opcion = 13) Then
                        LDefendas.Insertar(tempD)
                    End If
                    opcion = 44
                    ' <cierre> ::= '$' 

                Case ProductionIndex.Ruta_Ruta
                    If (opcion = 3) Then

                        tempF.fondo = Reduction.Item(0).Data.ToString()

                    ElseIf (opcion = 4) Then

                        tempF.musica = Reduction.Item(0).Data.ToString()

                    ElseIf (opcion = 6) Then

                        tempN.Rnave = Reduction.Item(0).Data.ToString()
                    ElseIf (opcion = 7) Then

                        tempN.Rdisparo = Reduction.Item(0).Data.ToString()
                    ElseIf (opcion = 8) Then

                        tempN.RSonido = Reduction.Item(0).Data.ToString()
                    ElseIf (opcion = 12) Then

                        tempD.imagen = Reduction.Item(0).Data.ToString()
                    End If
                    ' <Ruta> ::= Ruta 

                Case ProductionIndex.Rdefensa_Defensas
                    opcion = 11
                    tempD = New Defensas
                    ' <RDefensa> ::= defensas 

                Case ProductionIndex.Rescenario_Escenarios
                    opcion = 2
                    tempF = New Fondos
                    ' <REscenario> ::= escenarios 

                Case ProductionIndex.Rfondo_Fondo
                    opcion = 3
                    ' <RFondo> ::= fondo 

                Case ProductionIndex.Rimagene_Imagen_enemigo
                    ' <RImagenE> ::= 'imagen_enemigo' 

                Case ProductionIndex.Rimagen_def_Imagen_defensa
                    If (opcion = 11 Or opcion = 13) Then
                        opcion = 12
                    End If
                    ' <RImagen_Def> ::= 'imagen_defensa' 

                Case ProductionIndex.Rimagen_dis_Imagen_disparo
                    If (opcion = 5 Or opcion = 6 Or opcion = 8 Or opcion = 9 Or opcion = 10) Then
                        opcion = 7
                    End If
                    ' <RImagen_Dis> ::= 'imagen_disparo' 

                Case ProductionIndex.Rimagen_n_Imagen_nave
                    opcion = 6
                    ' <RImagen_N> ::= 'imagen_nave' 

                Case ProductionIndex.Rnave_Naves
                    opcion = 5
                    tempN = New Naves
                    ' <RNave> ::= naves 

                Case ProductionIndex.Rsonido_Sonido
                    If (opcion = 3 Or opcion = 2) Then
                        opcion = 4
                    End If
                    ' <RSonido> ::= sonido 

                Case ProductionIndex.Rsonido_dis_Sonido_disparo
                    If (opcion = 5 Or opcion = 6 Or opcion = 7 Or opcion = 9 Or opcion = 10) Then
                        opcion = 8
                    End If
                    ' <RSonido_Dis> ::= 'sonido_disparo' 

                Case ProductionIndex.Rvida_Vida
                    If (opcion = 5 Or opcion = 6 Or opcion = 7 Or opcion = 8 Or opcion = 10) Then
                        opcion = 9
                    End If
                    ' <RVida> ::= vida 

                Case ProductionIndex.Rataque_Ataque
                    If (opcion = 5 Or opcion = 6 Or opcion = 7 Or opcion = 8 Or opcion = 9) Then
                        opcion = 10
                    End If
                    ' <Rataque> ::= ataque 

                Case ProductionIndex.Rproteccion_Proteccion
                    If (opcion = 11 Or opcion = 12) Then
                        opcion = 13
                    End If
                    ' <RProteccion> ::= proteccion 

                Case ProductionIndex.Renemigo_Enemigos
                    ' <Renemigo> ::= enemigos 

                Case ProductionIndex.Rnombre_Nombre
                    ' <Rnombre> ::= nombre 

                Case ProductionIndex.Rfrecuencia_Frecuencia
                    ' <Rfrecuencia> ::= frecuencia 

                Case ProductionIndex.Rvelocidad_Velocidad
                    ' <RVelocidad> ::= velocidad 

                Case ProductionIndex.Rpunteo_Punteo
                    ' <Rpunteo> ::= punteo 

                Case ProductionIndex.Entero_Entero
                    If (opcion = 9) Then
                        tempN.vida = Double.Parse(.Item(0).Data.ToString)
                    ElseIf (opcion = 10) Then
                        tempN.ataque = Double.Parse(.Item(0).Data.ToString)
                    ElseIf (opcion = 13) Then
                        tempD.defensa = Double.Parse(.Item(0).Data.ToString)
                    End If
                    ' <Entero> ::= Entero 

                Case ProductionIndex.E_Plus
                    ' <E> ::= <E> '+' <MULT> 

                Case ProductionIndex.E_Minus
                    ' <E> ::= <E> '-' <MULT> 

                Case ProductionIndex.E
                    ' <E> ::= <MULT> 

                Case ProductionIndex.Mult_Times
                    ' <MULT> ::= <MULT> '*' <VALOR> 

                Case ProductionIndex.Mult_Div
                    ' <MULT> ::= <MULT> '/' <VALOR> 

                Case ProductionIndex.Mult
                    ' <MULT> ::= <VALOR> 

                Case ProductionIndex.Valor
                    ' <VALOR> ::= <Entero> 

                Case ProductionIndex.Valor_Lparen_Rparen
                    ' <VALOR> ::= '(' <E> ')' 

            End Select
        End With

        Dim a As String
        a = Reduction.Item(0).Data
        If (a <> "") Then
            a = a + "," + Reduction.Parent.TableIndex.ToString
            System.Console.WriteLine(a)
        End If


        Return Result
    End Function
End Module
