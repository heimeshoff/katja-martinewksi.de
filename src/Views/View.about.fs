module Katjanewski.Views.About

open Fable.React
open Fable.React.Props


let about model dispatch =
  [ 
    div [ Class "self-start lg:w-1/2" ]
      [ div [ Class "font-bold text-gray-700 text-3xl" ]
          [ str "About me"]
        p [ Class "text-justify" ]
          [ str "Die Promotion im Fachgebiet Chemie lehrte mir eine wissenschaftliche Denkweise. Die Weiterbildungen zur Führungskraft weckten schließlich mein starkes Interesse am Thema Kommunikation und Gruppendynamiken. Und diese Begeisterung möchte ich mit anderen WissenschaftlerInnen teilen. Gerade als Wissenschaftlerin ist mir Gleichberechtigung ein großes Anliegen. Ich unterstütze ihr Unternehmen gerne bei der Entwicklung eines Bewusstseins im Sinne der Gleichberechtigung." ] ]

    div [ Class "self-stretch lg:w-1/2 flex flex-col items-center"; Id "kontakt" ]
      [ div [ Class "font-bold text-gray-700 text-3xl" ]
          [ str "Kontakt"]
        p [ Class "text-justify" ]
          [ a 
              [ Class "hover:text-blue-300"
                Href "mailto:katja.martinewski@i2a-network.com"] 
              [ "katja.martinewski@i2a-network.com" |> ofString ]
            div []
              [ "+49 (160) 4542358" |> ofString ]
          ] 
      ]
  ]