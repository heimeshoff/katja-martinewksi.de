module Katjanewski.Views.Food

open Fable.React
open Fable.React.Props


let food model dispatch =
  div [ Class "content" ; Id "food saving"]
    [ div [ Class "my-8 w-4/5 lg:w-2/3 xl:w-1/2 flex flex-col md:flex-row items-start justify-between" ]
        [ div [ Class "m-4 md:w-1/3" ]
            [ img [ Src "/img/food.png" ] ]
          div [ Class "md:w-1/2" ]
            [ h2 [ ]
                [ str "Food Saving"]
              p [ Class "italic" ]
                [ str "Come let's eat, grandma. " ]
              p [ Class "pt-4" ]
                [ str "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur." ] ] 
         ]
    ]