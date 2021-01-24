module Katjanewski.Views.Hero

open Fable.React
open Fable.React.Props


let hero model dispatch =
    div [ Class "relative w-full max-h-screen flex flex-col items-center" ]
      [ 
        img 
          [ Class "w-full max-h-screen object-cover"
            Src "img/katja.jpg" ]

        div [ Class "absolute inset-0 flex flex-col items-center justify-end"]
          [
            div [ Class "glass bg-white bg-opacity-50 p-8 md:p-16 mb-8 rounded-md shadow-2xl" ]
              [
                div [ Class "font-bold text-gray-800 text-4xl md:text-6xl lg:text-8xl" ]
                  [ "Katja Martinewski" |> ofString ]
                div [ Class "text-xl md:text-2xl lg:text-3xl mt-6 ml-6" ]
                  [ "Let’s create the space for your development" |> ofString ]
              ]
          ]
      ] 