module Katjanewski.Views.Coaching

open Fable.React
open Fable.React.Props


let coaching model dispatch =
  [ 
    div [ Class "md:w-3/4 lg:w-1/2" ]
      [ div [ Class "font-bold text-gray-700 text-3xl" ]
          [ str "Coaching & Training"]
        p [ Class "text-justify" ]
          [ str "Falls Du ein Ziel verfolgst und effektiver im Arbeitsleben sein möchtest, aber nicht weißt, wie du es erreichen sollst, kann ich dir durch meine auf dem Prinzip des Solution focused Ansatz basierenden Coaching Methode helfen dieses Ziel zu erreichen." ] 
        p [ Class "text-justify" ]
          [ str "Dich erwarten in Trainings mit mir ein hoher Grad an Interaktion, damit aus Theorie auch Praxis wird." ] ] 

    img [ Class "lg:w-1/2 object-contain max-h-64"
          Src "/img/coaching.png" ]
  ]