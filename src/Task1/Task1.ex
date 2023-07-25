defmodule Divisibility do # Module declaration for the better organisation code
  def check_numbers do # Public function declaration
    # Generator, generates a number from 1 to 100 and passes that number to the check_divisibility function
    for n <- 1..100, do: check_divisibility(n)
  end

  defp check_divisibility(n) do # private function declaration
    cond do # if else statements
      rem(n, 3) == 0 and rem(n, 5) == 0 -> "Div3&5" # return Div3&5 if the number is divisible by 3 and 5
      rem(n, 3) == 0 -> "Div3" # return Div3 if the number is divisible by 3
      rem(n, 5) == 0 -> "Div5" # return Div5 if the number is divisible by 5
      true -> n # return the number itself
    end
  end
end

# Print results
IO.inspect(Divisibility.check_numbers())
