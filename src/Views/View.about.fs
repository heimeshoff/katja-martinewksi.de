module Katjanewski.Views.About

open Fable.React
open Fable.React.Props


let about model dispatch =
  div [ Class "w-full md:w-2/3 lg:w-1/2 py-4" ; Id "about me"]
    [ div [ Class "flex flex-col md:flex-row items-start justify-center space-x-4 space-y-4 "]
        [
          div [ Class "md:w-1/2" ]
            [ div [ Class "font-bold text-gray-700 text-3xl" ]
                [ str "About me"]
              p [ Class "pr-4 text-justify" ]
                [ str "Die Promotion im Fachgebiet Chemie lehrte mir eine wissenschaftliche Denkweise. Die Weiterbildungen zur Führungskraft weckten schließlich mein starkes Interesse am Thema Kommunikation und Gruppendynamiken. Und diese Begeisterung möchte ich mit anderen WissenschaftlerInnen teilen. Gerade als Wissenschaftlerin ist mir Gleichberechtigung ein großes Anliegen. Ich unterstütze ihr Unternehmen gerne bei der Entwicklung eines Bewusstseins im Sinne der Gleichberechtigung." ] ]
          div [ Class "md:w-1/2"; Id "kontakt" ]
            [ div [ Class "font-bold text-gray-700 text-3xl" ]
                [ str "Kontakt"]
              p [ Class "pr-4 text-justify" ]
                [ a 
                    [ Class "hover:text-blue-300"
                      Href "mailto:katja.martinewski@i2a-network.com"] 
                    [ "katja.martinewski@i2a-network.com" |> ofString ]
                  div []
                    [ "+49 (160) 4542358" |> ofString ]
                ] 
            ]
        ]
    ]