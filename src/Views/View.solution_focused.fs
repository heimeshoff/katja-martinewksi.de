module Katjanewski.Views.Solution_focused

open Fable.React
open Fable.React.Props


let solution_focused model dispatch =
  [ 
    div [ Class "w-1/2 flex flex-col items-center" ]
      [
        a [ Href "https://sfio.org/" 
            Target "_blank"]
          [ img [ 
              Class "w-64 mb-4 floating-action-button"
              Src "/img/sfio.png" ] ]
        a [ Href "https://www.i2a-network.com/" 
            Target "_blank" ]
          [ img [ Class "w-64 floating-action-button"
                  Src "/img/i2a.png" ] ]
      ]
      
    div [ Class "md:w-3/4 lg:w-1/2"]
      [
        div [ Class "font-bold text-gray-700 text-3xl" ]
          [ str "Solution Focused Approach"]
        p [ Class "text-justify" ]
          [ str "Der Solution Focused Ansatz konzentriert sich auf die Möglichkeiten, die bereits funktioniert haben und auf das was erreicht werden möchte - Weniger auf die problemerzeugenden Aspekte. Hierdurch helfe ich Dir aus blockierendem Denken zu zukunftsorientiertem Handeln zu kommen." ] 
        p [ Class "text-justify" ]
          [ str "Durch meine Vernetzung mit SFiO (Solution Focus in Organisations) und dem I2A Network kann ich auf viele Ressourcen zurückgreifen." ] 
      ]
  ]