import edamam
import yelp

def main():
    dish = edamam.main()
    empty = check_empty(dish)

    if empty == False:
        location = yelp.main(dish)

def check_empty(dish):
    if dish == "":
        return True
    else:
        return False

if __name__ == "__main__":
    main()