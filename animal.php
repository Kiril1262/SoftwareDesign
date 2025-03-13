<?php
session_start();


if (!isset($_SESSION['zoo_data'])) {
    $_SESSION['zoo_data'] = [
        'animals' => [
            ["name" => "Сімба", "species" => "Лев", "age" => 5],
            ["name" => "Нага", "species" => "Кобра", "age" => 4],
            ["name" => "Полі", "species" => "Папуга", "age" => 2],
            ["name" => "Мурзик", "species" => "Тигр", "age" => 6],
            ["name" => "Грета", "species" => "Жираф", "age" => 8],
            ["name" => "Боб", "species" => "Бегемот", "age" => 12],
            ["name" => "Ліза", "species" => "Зебра", "age" => 4],
            ["name" => "Кеша", "species" => "Орлан", "age" => 5],
            ["name" => "Роккі", "species" => "Ведмідь", "age" => 9],
            ["name" => "Тіна", "species" => "Пітон", "age" => 7],
            ["name" => "Рекс", "species" => "Вовк", "age" => 6],
            ["name" => "Гері", "species" => "Лемур", "age" => 3],
            ["name" => "Джек", "species" => "Кенгуру", "age" => 5],
            ["name" => "Соня", "species" => "Коала", "age" => 4],
            ["name" => "Бруно", "species" => "Горила", "age" => 10],
        ],
        'food' => [
            ["name" => "Яловичина", "type" => "М'ясо", "quantity" => 500, "expiration_date" => "2025-01-01"],
            ["name" => "Морква", "type" => "Овочі", "quantity" => 100, "expiration_date" => "2024-12-01"],
            ["name" => "Пшениця", "type" => "Зерно", "quantity" => 200, "expiration_date" => "2024-11-01"],
        ],
        'employees' => [
            ["name" => "Іван", "position" => "Доглядальник"],
            ["name" => "Марія", "position" => "Ветеринар"],
            ["name" => "Олег", "position" => "Екскурсовод"],
        ]
    ];
}

$data = $_SESSION['zoo_data'];
?>

<!DOCTYPE html>
<html lang="uk">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Зоопарк</title>
    <link rel="stylesheet" href="animal.css"/>
</head>
<body>
    <h1>Зоопарк</h1>
    
    <h2>Тварини</h2>
    <ul>
        <?php foreach ($data['animals'] as $animal): ?>
            <li><?= $animal['name'] ?> (<?= $animal['species'] ?>), <?= $animal['age'] ?> років</li>
        <?php endforeach; ?>
    </ul>

    <h2>Запаси їжі</h2>
    <ul>
        <?php foreach ($data['food'] as $item): ?>
            <li><?= $item['name'] ?> (<?= $item['type'] ?>): <?= $item['quantity'] ?> кг, придатність до <?= $item['expiration_date'] ?></li>
        <?php endforeach; ?>
    </ul>

    <h2>Працівники</h2>
    <ul>
        <?php foreach ($data['employees'] as $emp): ?>
            <li><?= $emp['name'] ?> – <?= $emp['position'] ?></li>
        <?php endforeach; ?>
    </ul>

    <a href="report.php">Переглянути звіт</a>
</body>
</html>

