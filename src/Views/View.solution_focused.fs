module Katjanewski.Views.Solution_focused

open Fable.React
open Fable.React.Props


let solution_focused model dispatch =
  div [ Class "w-full md:w-2/3 lg:w-1/2" ; Id "solution focused"]
    [ div [ Class "flex flex-col md:flex-row items-center justify-center space-x-4 space-y-4 "]
        [
          div [ Class "md:w-1/2 px-4" ]
            [ div [ Class "font-bold text-gray-700 text-3xl" ]
                [ str "Solution Focused Approach"]
              p [ Class "pr-4 text-justify" ]
                [ str "Der Solution Focused Ansatz konzentriert sich auf die Möglichkeiten, die bereits funktioniert haben und auf das was erreicht werden möchte - Weniger auf die problemerzeugenden Aspekte. Hierdurch helfe ich Dir aus blockierendem Denken zu zukunftsorientiertem Handeln zu kommen." ] 
              p [ Class "pr-4 text-justify" ]
                [ str "Durch meine Vernetzung mit SFiO (Solution Focus in Organisations) und dem I2A Network kann ich auf viele Ressourcen zurückgreifen." ] ]
          div [ Class "w-1/2" ]
            [
              a [ Href "https://sfio.org/" 
                  Target "_blank"]
                [ img [ 
                    Class "w-64 shadow-md mb-2"
                    Src "/img/sfio.png" ] ]
              a [ Href "https://www.i2a-network.com/" 
                  Target "_blank" ]
                [ img [ Class "w-64 shadow-md"
                        Src "/img/i2a.png" ] ]
            ]
        ]
    ]